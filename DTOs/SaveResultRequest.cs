using System.ComponentModel.DataAnnotations;

namespace iptipBackend.DTOs
{
    public class SaveResultRequest
    {
        [Required(ErrorMessage = "Question1 is required.")]
        public string? Question1 { get; set; }

        [Required(ErrorMessage = "Question2 is required.")]
        public string? Question2 { get; set; }
        public string? Question3 { get; set; }
    }
}
