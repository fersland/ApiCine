using AutoMapper;
using csharp_apis_cinema.DTO;
using csharp_apis_cinema.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace csharp_apis_cinema.Controllers
{
    [ApiController]
    [Route("Sistemas/Programadores")]
    public class ProgramadoresController : Controller
    {
        private readonly DataContext db;
        private readonly IMapper mp;

        public ProgramadoresController(DataContext db, IMapper mp)
        {
            this.db = db;
            this.mp = mp;
        }

        [HttpPost]
        [Route("Guardar")]
        public async Task<ActionResult> Guardar(ProgramadorDto dto)
        {
            var response = mp.Map<Programador>(dto);
            db.Add(response);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpPost]
        [Route("GuardarVariosProgramadores")]
        public async Task<ActionResult> GuadarVarios(ProgramadorDto[] dto)
        {
            var response = mp.Map<Programador[]>(dto);
            db.AddRange(response);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("ListarProgramadores")]
        public async Task<ActionResult<IEnumerable<Programador>>> Listar()
        {
            return await db.Programadores.ToListAsync();
        }
    }
}
