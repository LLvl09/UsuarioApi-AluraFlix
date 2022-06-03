using System.ComponentModel.DataAnnotations;

namespace UsuarioAluraFlix.Data.Request
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "precisa informar o username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "precisa informar a senha ")]
        public string Password { get; set; }
    }
}