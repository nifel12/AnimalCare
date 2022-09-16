using Microsoft.EntityFrameworkCore;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public class AppContext : DbContext //estos : es herencia
    {
        public DbSet<Persona> Personas {get;set;} //esto es la tabla, lo que esta entre <> es la clase del dominio
        public DbSet<Veterinario> Veterinarios {get;set;}
        public DbSet<Dueno> Duenos {get;set;}
        public DbSet<VisitaPyP> VisitasPyP {get;set;}
        public DbSet<Historia> Historias {get;set;}
        public DbSet<Mascota> Mascotas {get;set;}
        //hay que importar desde dominio porque alla estan todas las clases
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MascotaFelizData");
                //esto hace la conexion con la bd
            }
        }
    }
}