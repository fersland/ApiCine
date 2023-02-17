using AutoMapper;
using csharp_apis_cinema.DTO;
using Microsoft.AspNetCore.Mvc;
using csharp_apis_cinema.Entidades;
using Microsoft.EntityFrameworkCore;

namespace csharp_apis_cinema.Controllers
{
    [ApiController]
    [Route("Cine/Actores")]
    public class ActoresController : Controller
    {
        private readonly DataContext db;
        private readonly IMapper mapper;

        public ActoresController(DataContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actor>>> Listar()
        {
            return await db.Actores.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Guardar(ActorDto dto)
        {
            var response = mapper.Map<Actor>(dto);
            db.Add(response);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}
