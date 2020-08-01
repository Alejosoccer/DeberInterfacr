using Microsoft.EntityFrameworkCore;
using Profesion.Interface;
using Profesion.Entidadades;

namespace Profesiones.AccesoDatos
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Medico1> Medico1 { get; set; }
    }
}
