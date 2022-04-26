using Microsoft.EntityFrameworkCore;
using PrestamoGJ.Application.Core.Dtos;
using PrestamoGJ.Application.Core.Interfaces.Repositories;
using PrestamoGJ.Domain.Entities;
using PrestamoGJ.Infrastructure.Repositories.Oracle;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace PrestamoGJ.Infrastructure.Repositories
{
    public class CustomUsuarioRepository : IUsuarioRepository
    {
        private readonly SQL_DbContext context;

        public CustomUsuarioRepository(SQL_DbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Usuario>> GetUsuarios()
        {
            var result = await context.Usuarios.FromSqlInterpolated($@"EXEC spmostrar_trabajador")
                                     .ToArrayAsync();

            return result;
        }

        public async Task<int> InsetarUsuario(UsuarioDto usuario)
        {
            var paramaterId = new SqlParameter("@idtrabajador", SqlDbType.Int);
            paramaterId.Direction = ParameterDirection.Output;

            await context.Database.ExecuteSqlInterpolatedAsync($@"EXEC spinsertar_trabajador @nombre={usuario.nombre},@apellido={usuario.apellido},@sexo={usuario.sexo},
                                                  @fecha_nacimiento={usuario.fecha_nac},@num_documento={usuario.num_documento},@direccion={usuario.direccion},
                                                  @email={usuario.email},@acceso={usuario.acceso},@usuario={usuario.usuario},@password={usuario.password},@idtrabajador={paramaterId} OUTPUT");

            var id = (int)paramaterId.Value;
            return id;
        }
    }
}
