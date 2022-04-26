using PrestamoGJ.Application.Core.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrestamoGJ.Application.Core.Interfaces.BusinessServices
{
    public interface IUsuarioService
    {
        Task<IEnumerable<UsuarioDto>> GetUsuarios();
        Task<int> InsetarUsuario(UsuarioDto usuario);
    }
}
