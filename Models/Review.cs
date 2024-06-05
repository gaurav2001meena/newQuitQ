using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewQuitQ.Models
{
    [Table("Review")]
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        public int UserId { get; set;}
        public User? User { get; set; }

        [Required]
        public int ProductId { get; set; }

        public Products? Products { get; set; }

        [Required]
        public string Comments { get; set; }
    }
}
