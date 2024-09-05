using System.ComponentModel.DataAnnotations;

namespace MVC_Identity.Models.ViewModel
{
    public class RegisterViewModel
    {

        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(35)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(30)]
        [MinLength(3)]
        public string Password { get; set; }
      
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(30)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }


        
    }
}
