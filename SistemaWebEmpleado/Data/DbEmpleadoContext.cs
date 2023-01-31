using Microsoft.EntityFrameworkCore;
using SistemaWebEmpleado.Models;

namespace SistemaWebEmpleado.Data
{
    public class DbEmpleadoContext: DbContext
    {
        public DbEmpleadoContext(DbContextOptions<DbEmpleadoContext> options) : base(options) { }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
