using System.ComponentModel.DataAnnotations;

namespace NJAuto.Shared.Models
{
    public class RegisterUser
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
