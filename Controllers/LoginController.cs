using FluentResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsuarioAluraFlix.Data.Request;
using UsuarioAluraFlix.Models;
using UsuarioAluraFlix.Services;

namespace UsuarioAluraFlix.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private TokenService _tokenService;
        private SignInManager<IdentityUser<int>> _signInManager;
        public LoginController(TokenService tokenService, SignInManager<IdentityUser<int>> signInManager)
        {
            _tokenService = tokenService;
            _signInManager = signInManager;
        }

        [HttpPost]
        public IActionResult LogaUsuario(LoginRequest request)
        {
            //pegando usuario e password
            var resultadoIdentity = _signInManager
                .PasswordSignInAsync(request.Username, request.Password, false, false);

            if (resultadoIdentity.Result.Succeeded)
            {
                //verificando se usuario é valido
                var identityUser = _signInManager
                    .UserManager
                    .Users
                    .FirstOrDefault(usuario =>
                    usuario.NormalizedUserName == request.Username.ToUpper());

                //Criando token e configurando role
                Token token = _tokenService.CreateToken(identityUser, _signInManager
                    .UserManager.GetRolesAsync(identityUser).Result.FirstOrDefault());

                //retornando valor do token
                return Ok(token.Value);
            }
            return StatusCode(500);
        }
    }
}