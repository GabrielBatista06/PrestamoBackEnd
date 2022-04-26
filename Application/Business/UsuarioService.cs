using AutoMapper;
using PrestamoGJ.Application.Core.Dtos;
using PrestamoGJ.Application.Core.Interfaces.BusinessServices;
using PrestamoGJ.Application.Core.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrestamoGJ.Application.Core.Business
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository usuarioRepository;
        private readonly IMapper mapper;

        public UsuarioService(IUsuarioRepository usuarioRepository,
                              IMapper mapper)
        {
            this.usuarioRepository = usuarioRepository;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<UsuarioDto>> GetUsuarios()
        {
            var result = await usuarioRepository.GetUsuarios();

            return mapper.Map<IEnumerable<UsuarioDto>>(result);
        }

        public async Task<int> InsetarUsuario(UsuarioDto usuario)
        {
            var result = await usuarioRepository.InsetarUsuario(usuario);
            return result;
        }
    }
}
