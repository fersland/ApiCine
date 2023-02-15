using AutoMapper;
using csharp_apis_cinema.DTO;
using csharp_apis_cinema.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace csharp_apis_cinema.Controllers
{
    [ApiController]
    [Route("Cine/Generos")]
    public class GenerosController : Controller
    {
        private readonly DataContext db;
        private readonly IMapper mapper;
        public GenerosController(DataContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        [HttpPost]
        [Route("GuardarGenero")]
        public async Task<ActionResult> Guardar(GeneroDto model)
        {
            var response = await db.Generos.AnyAsync(x => x.Nombre == model.Nombre);

            if (response)
            {
                return BadRequest("Este genero ya esta registrado: " + model.Nombre);
            }

            var item = mapper.Map<Genero>(model);
            db.Add(item);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        [Route("ListarGeneros")]
        public async Task<ActionResult<IEnumerable<Genero>>> Listar()
        {
            return await db.Generos.ToListAsync();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genero>>> ListarNombre()
        {
            var response = await db.Generos.Select(x => new { x.Nombre }).ToListAsync();
            return Ok(response);
        }

        [HttpPut("{id=int}/update")]
        public async Task<ActionResult> Actualizar(int id, GeneroDto dto)
        {
            var edit = mapper.Map<Genero>(dto);
            edit.Id = id;
            db.Update(edit);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}/delete")]
        public async Task<ActionResult> Eliminar(int id)
        {
            var delete = await db.Generos.Where(x => x.Id == id).ExecuteDeleteAsync();
            if (delete == 0)
            {
                return NotFound();
            }

            return NoContent();

        }
    }
}
