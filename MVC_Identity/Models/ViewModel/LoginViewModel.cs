
using System.ComponentModel.DataAnnotations;

namespace MVC_Identity.Models.ViewModel
{
    public class LoginViewModel 
    {

   //     [Required]
     //   [EmailAddress]
       // [MaxLength(30)]
       // [Display(Name ="Email Adress")]
        //public string Email {  get; set; }


        [Required]
        [MaxLength(30)]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(30)]
   
        public string Password { get; set; }

        public bool Rememberme { get; set; } 
    }
}
