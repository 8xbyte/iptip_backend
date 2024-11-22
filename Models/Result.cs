using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iptipBackend.Models{
    [Table("results")]
    public class Result {
        [Key]
        public int Id { get; set; }
        public string Question1 { get; set; } = null!;
        public string Question2 { get; set;} = null!;
        public string? Question3 { get; set;} = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}