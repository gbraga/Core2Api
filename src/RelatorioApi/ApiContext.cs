using Microsoft.EntityFrameworkCore;
using RelatorioApi.Dominio.Entities;

namespace RelatorioApi
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public DbSet<Periodo> Periodos { get; set; }
    }
}
