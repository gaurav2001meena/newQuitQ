using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewQuitQ.Models
{

    [Table("OrderItems")]
    public class OrderItems
    {
        [Key]
        public int OrderItemId { get; set; }

        [Required]

        public int OrderId { get; set; }

        public Orders? Orders { get; set; }

        [Required]

        public int ProductId { get; set; }  

        public Products? Products { get; set; }

        [Required]

        public int Quantity { get; set; }

        [Required]
        public float ItemTotalPrice { get; set; }
    }
}
