using System.ComponentModel.DataAnnotations;

namespace UsuarioAluraFlix.Models
{
    public class Usuario
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "precisa informar o username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "precisa informar o email")]
        public string Email { get; set; }
    }
}