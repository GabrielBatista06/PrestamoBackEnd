using PrestamoGJ.Application.Core.Dtos;
using PrestamoGJ.Domain.Entities;
using System.Threading.Tasks;

namespace PrestamoGJ.Application.Core.Interfaces.Repositories
{
    public interface ILoginRepository
    {
        Task<Usuario> GetUsuario(RequestLoginDto loginDto);
    }
}
