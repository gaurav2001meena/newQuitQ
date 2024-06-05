using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewQuitQ.Models
{
    [Table("Payments")]
    public class Payments
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        public int OrderID { get; set; }
        public Orders? Orders { get; set; }

        [Required]
        public string PaymentMode { get; set; }

        [Required]
        public string PaymentStatus { get; set; }
    }
}
