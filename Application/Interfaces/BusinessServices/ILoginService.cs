using PrestamoGJ.Application.Core.Dtos;
using PrestamoGJ.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrestamoGJ.Application.Core.Interfaces.BusinessServices
{
    public interface ILoginService
    {
        Task<Usuario> GetUsuario(RequestLoginDto login);
    }
}
