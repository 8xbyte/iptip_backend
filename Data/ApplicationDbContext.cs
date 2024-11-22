using Microsoft.EntityFrameworkCore;
using iptipBackend.Models;

namespace iptipBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public required DbSet<Result> Results { get; set; }
    }
}
