using Microsoft.EntityFrameworkCore;
using csharp_apis_cinema.Entidades;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Runtime.CompilerServices;

namespace csharp_apis_cinema
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options){}

        public DbSet<Genero> Generos => Set<Genero>();

        protected override void OnModelCreating (ModelBuilder args)
        {
            args.Entity<Genero>().HasKey(g => g.Id);
            args.Entity<Genero>().Property(g => g.Nombre).HasMaxLength(150);
        }


    }
}
