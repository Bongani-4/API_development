  
using System.ComponentModel.DataAnnotations;


namespace WebApp_35016752_P2.Authentication
    { 
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}

