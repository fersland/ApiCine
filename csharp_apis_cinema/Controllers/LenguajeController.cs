using AutoMapper;
using csharp_apis_cinema.DTO;
using csharp_apis_cinema.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Serialization;

namespace csharp_apis_cinema.Controllers
{
    [ApiController]
    [Route("Sistema/Lenguajes")]
    public class LenguajeController : Controller
    {
        private readonly DataContext db;
        private readonly IMapper mp;

        public LenguajeController(DataContext db, IMapper mp)
        {
            this.db = db;
            this.mp = mp;
        }
        
        [HttpPost]
        [Route("Guardar")]
        public async Task<ActionResult> Guardar(LenguajeDto dto)
        {
            var rem = mp.Map<Lenguaje>(dto);
            db.Add(rem);
            await db.SaveChangesAsync();
            return Ok();
        }
        
        [HttpPost(Name = "GuardarVarios")]
        public async Task<ActionResult> GuardarMultiple(LenguajeDto[] dto)
        {
            var rem = mp.Map<Lenguaje[]>(dto);
            db.AddRange(rem);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lenguaje>>> Listar()
        {
            var rem = await db.Lenguajes.Select(l => new {l.Nombre}).ToListAsync();
            return Ok(rem);
        }
    }
}
