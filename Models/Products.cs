using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewQuitQ.Models
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        [Required]

        public string ProductName { get; set; }

        [Required]
        public string ProductDescription { get; set; }

        [Required]
        public float ProductPrice { get; set; }

        [Required]

        public int CategoryId {  get; set; }
        public Categories? Categories { get; set; }

        [Required]

        public int UserID { get; set; }
        public User? User { get; set; }

        public string ProductUrl {  get; set; }

        [Required]

        public bool Is_Deleted { get; set; } = false;

    }
}
