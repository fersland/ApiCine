using Microsoft.EntityFrameworkCore;
using csharp_apis_cinema.Entidades;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Runtime.CompilerServices;

namespace csharp_apis_cinema
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options){}
                
        protected override void OnModelCreating (ModelBuilder args)
        {
            args.Entity<Genero>().HasKey(g => g.Id);
            args.Entity<Genero>().Property(g => g.Nombre).HasMaxLength(150);

            args.Entity<Pelicula>().HasKey(p => p.Id);
            args.Entity<Pelicula>().Property(x => x.Titulo).HasMaxLength(150);
            args.Entity<Pelicula>().Property(x => x.FechaEstreno).HasColumnType("Date");

            args.Entity<Actor>().HasKey(a => a.Id);
            args.Entity<Actor>().Property(a => a.Nombre).HasMaxLength(150);

            args.Entity<PeliculaActor>().HasKey(pa => new { pa.ActorId, pa.PeliculaId });
        }

        public DbSet<Genero> Generos => Set<Genero>();
        public DbSet<Pelicula> Peliculas => Set<Pelicula>();
        public DbSet<Actor> Actores => Set<Actor>();
        public DbSet<Comentario> Comentarios => Set<Comentario>();
        public DbSet<PeliculaActor> PeliculasActores => Set<PeliculaActor>();
    }
}