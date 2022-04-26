using Microsoft.AspNetCore.Mvc;
using PrestamoGJ.Application.Core.Dtos;
using PrestamoGJ.Application.Core.Interfaces.BusinessServices;
using System.Threading.Tasks;

namespace PrestamoGJ.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }
        [HttpPost]
        public async Task<IActionResult> InsertarUsuario([FromBody] UsuarioDto usuario)
        {
            var result = await usuarioService.InsetarUsuario(usuario);

            if (result == 0)
            {
                return BadRequest(new { message = "!Error¡ Ha ocurrido un error intentando crear el usuario" });
            }
            return Ok(new { message = "Usuario registrado de manera exitosa" });

        }
        [HttpGet]
        public async Task<ActionResult> GetUsuario()
        {
            var result = await usuarioService.GetUsuarios();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
