using System.ComponentModel.DataAnnotations;

namespace csharp_apis_cinema.DTO
{
    public class ProgramadorDto
    {
        [StringLength(maximumLength: 150)]
        public string Nombre { get; set; } = null!;
        public int Edad { get; set; }
    }
}
