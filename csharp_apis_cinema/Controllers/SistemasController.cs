using AutoMapper;
using csharp_apis_cinema.DTO;
using csharp_apis_cinema.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace csharp_apis_cinema.Controllers
{
    [ApiController]
    [Route("Sistema/Sistemas Computacionales")]
    public class SistemasController : Controller
    {
        private readonly DataContext db;
        private readonly IMapper mp;

        public SistemasController(DataContext db, IMapper mp)
        {
            this.db = db;
            this.mp = mp;
        }

        [HttpPost]
        [Route("CrearDescripcionSistema")]
        public async Task<ActionResult> Guardar(SistemaDto dto)
        {
            var sistema = mp.Map<Sistema>(dto);
            if (sistema.Lenguajes is not null)
            {
                foreach (var lenguaje in sistema.Lenguajes)
                {
                    db.Entry(lenguaje).State = EntityState.Unchanged;
                }
            }

            db.Add(sistema);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}