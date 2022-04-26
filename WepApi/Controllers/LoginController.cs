using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PrestamoGJ.Application.Core.Dtos;
using PrestamoGJ.Application.Core.Interfaces.BusinessServices;
using PrestamoGJ.Application.Core.Utils;
using System;
using System.Threading.Tasks;

namespace PrestamoGJ.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _usuarioService;
        private readonly IConfiguration _configuration;

        public LoginController(ILoginService usuarioService,
                               IConfiguration configuration)
        {
            this._usuarioService = usuarioService;
            this._configuration = configuration;
        }
        [HttpPost]
        public async Task<ActionResult> Test([FromBody] RequestLoginDto login)
        {
            try
            {
                //login.password = Encriptar.EncriptarPassword(login.password);
                var user = await _usuarioService.GetUsuario(login);

                if (user == null)
                {
                    return BadRequest(new { message = "Usuario o/y contraseña incorrectos."});

                }
                string tokenString = JwtConfigurator.GetToken(user, _configuration);
                return Ok(new { token = tokenString });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

    }

}
