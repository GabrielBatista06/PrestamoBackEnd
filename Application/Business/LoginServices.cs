using PrestamoGJ.Application.Core.Dtos;
using PrestamoGJ.Application.Core.Interfaces.BusinessServices;
using PrestamoGJ.Application.Core.Interfaces.Repositories;
using PrestamoGJ.Domain.Entities;
using System.Threading.Tasks;

namespace PrestamoGJ.Application.Core.Business
{
    public class LoginServices : ILoginService
    {
        private readonly ILoginRepository usuarioRepository;

        public LoginServices(ILoginRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }
        public async Task<Usuario> GetUsuario(RequestLoginDto login) => await usuarioRepository.GetUsuario(login);

    }
}
