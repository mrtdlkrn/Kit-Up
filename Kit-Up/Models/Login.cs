using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Kit_Up.Models
{
    public class Login
    {
        [Required]
        [DisplayName("EPosta")]
        [EmailAddress(ErrorMessage = "Eposta adresinizi düzgün giriniz.")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }
        [DisplayName("Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}