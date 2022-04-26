using PrestamoGJ.Application.Core.Dtos;
using PrestamoGJ.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrestamoGJ.Application.Core.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetUsuarios();
        Task<int> InsetarUsuario(UsuarioDto usuario);
    }
}
