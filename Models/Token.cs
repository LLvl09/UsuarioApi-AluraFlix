using System.ComponentModel.DataAnnotations;

namespace UsuarioAluraFlix.Models
{
    public class Token
    {
        public Token(string value)
        {
            Value = value;
        }
        [Required]
        public string Value { get; }
    }
}