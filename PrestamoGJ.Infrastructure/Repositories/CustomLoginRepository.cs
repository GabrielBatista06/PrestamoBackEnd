using PrestamoGJ.Application.Core.Interfaces.Repositories;
using PrestamoGJ.Domain.Entities;
using PrestamoGJ.Infrastructure.Repositories.Oracle;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrestamoGJ.Application.Core.Dtos;

namespace PrestamoGJ.Infrastructure.Repositories
{
    public class CustomLoginRepository : ILoginRepository
    {
        private readonly SQL_DbContext context;

        public CustomLoginRepository(SQL_DbContext context) 
        {
            this.context = context;
        }

        public async Task<Usuario> GetUsuario(RequestLoginDto loginDto)
        {
           var result =  context.Usuarios.FromSqlInterpolated($@"EXEC splogin @usuario={loginDto.usuario},@password={loginDto.password}")
                                                .AsAsyncEnumerable();

            await foreach (var item in result)
            {
                return item;
            }
            return null;
        }
    }

}

