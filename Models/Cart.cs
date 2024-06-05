using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewQuitQ.Models
{
    [Table("Cart")]
    public class Cart
    {
        [Key]
        public int CartId { get; set; }

        [Required]

        public int UserId { get; set; }

        public User? User { get; set; }

        [Required]

        public int ProductId {  get; set; }

        public Products? Products { get; set; }

        [Required]

        public int Quantity { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public bool Is_Deleted { get; set; } = false;


    }
}
