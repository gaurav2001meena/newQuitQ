using System.ComponentModel.DataAnnotations;

namespace NewQuitQ.Models
{
 
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public string Address { get; set; }

        [Required]
        public int Phone {  get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public bool Is_Deleted { get; set; } = false;


    }
}
