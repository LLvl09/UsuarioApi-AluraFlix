using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using UsuarioAluraFlix.Models;

namespace UsuarioAluraFlix.Services
{
    public class TokenService
    {
        public Token CreateToken(IdentityUser<int> usuario, string role)
        {
            //definindo os direitos do usuario
            Claim[] direitosUsuario = new Claim[]
            {
                new Claim("username", usuario.UserName),
                new Claim("id", usuario.Id.ToString()),
                new Claim("role", role),
            };
            //pegando a key
            var chave = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes("0asdjas09djsa09djasdjsadajsd09asjd09sajcnzxn")
                );
            //configurando credenciais    
            var credenciais = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);
            //criando o token
            var token = new JwtSecurityToken(
                claims: direitosUsuario,
                signingCredentials: credenciais,
                expires: DateTime.UtcNow.AddHours(1)
                );
            //transformando token em string
            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            return new Token(tokenString);
        }
    }
}