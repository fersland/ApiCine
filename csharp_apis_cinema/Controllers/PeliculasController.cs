using AutoMapper;
using csharp_apis_cinema.DTO;
using csharp_apis_cinema.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace csharp_apis_cinema.Controllers
{
    [ApiController]
    [Route("Cinema/Peliculas")]
    public class PeliculasController : Controller
    {
        private readonly DataContext db;
        private readonly IMapper mapper;

        public PeliculasController(DataContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Guardar(PeliculaDto dto)
        {
            var pelicula = mapper.Map<Pelicula>(dto);
            if (pelicula.Generos is not null)
            {
                foreach(var genero in pelicula.Generos)
                {
                    db.Entry(genero).State = EntityState.Unchanged;
                }
            }

            if (pelicula.PeliculasActores is not null)
            {
                for(int i = 0; i<pelicula.PeliculasActores.Count; i++)
                {
                    pelicula.PeliculasActores[i].Orden = i + 1;
                }
            }

            db.Add(pelicula);
            await db.SaveChangesAsync();
            return Ok();
        }
        
    }
}
