using Microsoft.EntityFrameworkCore;
using csharp_apis_cinema.Entidades;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;

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
            args.Entity<SistemaProgramador>().HasKey(sp => new { sp.ProgramadorId, sp.SistemaId });


            args.Entity<Sistema>().HasKey(s => s.Id);
            args.Entity<Sistema>().Property(s => s.Nombre).HasMaxLength(150);

            args.Entity<Programador>().HasKey(p => p.Id);
            args.Entity<Programador>().Property(p => p.Nombre).HasMaxLength(150);

            args.Entity<Lenguaje>().HasKey(l => l.Id);
            args.Entity<Lenguaje>().Property(l => l.Nombre).HasMaxLength(150);
        }

        public DbSet<Genero> Generos => Set<Genero>();
        public DbSet<Pelicula> Peliculas => Set<Pelicula>();
        public DbSet<Actor> Actores => Set<Actor>();
        public DbSet<Comentario> Comentarios => Set<Comentario>();
        public DbSet<PeliculaActor> PeliculasActores => Set<PeliculaActor>();

        public DbSet<Programador> Programadores => Set<Programador>();
        public DbSet<Sistema> Sistemas => Set<Sistema>();
        public DbSet<Lenguaje> Lenguajes => Set<Lenguaje>();
        public DbSet<SistemaProgramador> SistemasProgramadores => Set<SistemaProgramador>();
    }
}