using Microsoft.EntityFrameworkCore;
using PrestamoGJ.Domain.Entities;

namespace PrestamoGJ.Infrastructure.Repositories.Oracle
{
    public class SQL_DbContext : DbContext
    {
        public SQL_DbContext(DbContextOptions<SQL_DbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
