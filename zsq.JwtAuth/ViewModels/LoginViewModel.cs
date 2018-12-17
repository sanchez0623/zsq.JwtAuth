using System.ComponentModel.DataAnnotations;

namespace zsq.JwtAuth.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}