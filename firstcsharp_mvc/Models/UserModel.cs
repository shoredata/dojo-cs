using System.ComponentModel.DataAnnotations;


namespace firstcsharp_mvc.Models
{
    public class UserModel
    {
        [Required]
        [MinLength(3)]
        [Display(Name = "Your Name:")] 
        public string Name { get; set; }
 
        [Required]
        [EmailAddress]
        public string Email { get; set; }
 
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}