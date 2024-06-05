using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewQuitQ.Models
{
    [Table("Users")]
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]

        public string CategoryName { get; set; }

        [Required]

        public bool Is_Deleted { get; set; } = false;
    }
}
