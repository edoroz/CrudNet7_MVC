using CrudNet7MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNet7MVC.Contexto {
    public class AppDbContext : DbContext {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        } //-ctr

        // Agregar los modelos
        public DbSet<Contacto> Contacto { get; set; }
    }
}
