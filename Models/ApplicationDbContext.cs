using Microsoft.EntityFrameworkCore;

namespace WebApiLocalidad.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
            
        }
        public DbSet<Pais> Paises { get; set; }
    }
}