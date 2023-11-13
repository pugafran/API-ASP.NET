using APIClientes.Modelos;
using Microsoft.EntityFrameworkCore;

namespace APIClientes.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opciones): base(opciones)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }

    }
}
