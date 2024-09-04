using API_Prueba04092024.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace API_Prueba04092024.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Publicacion> Publicaciones{ get; set; }







    }
}
