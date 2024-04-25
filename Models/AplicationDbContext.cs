using Microsoft.EntityFrameworkCore;
namespace BE_CRUDMASCOTAS.Models
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options){

        }
        public DbSet<Mascota> Mascotas {get; set;}
    }
}