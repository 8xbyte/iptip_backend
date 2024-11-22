using Microsoft.AspNetCore.Mvc;
using iptipBackend.Data;
using iptipBackend.DTOs;
using iptipBackend.Models;

namespace iptipBackend.Controllers
{
    [ApiController]
    [Route("api/results")]
    public class ResultsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ResultsController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Сохраняет результаты теста в базе данных.
        /// </summary>
        /// <param name="request">Ответы пользователя.</param>
        /// <returns>Результат выполнения операции.</returns>
        [HttpPost]
        public async Task<ActionResult> SaveResult([FromBody] SaveResultRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Question1))
            {
                return BadRequest("Question1 is required.");
            }

            if (string.IsNullOrWhiteSpace(request.Question2))
            {
                return BadRequest("Question2 is required.");
            }
            var result = new Result
            {
                Question1 = request.Question1,
                Question2 = request.Question2,
                Question3 = request.Question3
            };

            await _context.Results.AddAsync(result);
            await _context.SaveChangesAsync();

            return Ok(new { Message = "Result saved successfully" });
        }
    }
}
