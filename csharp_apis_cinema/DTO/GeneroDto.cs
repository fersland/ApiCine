using System.ComponentModel.DataAnnotations;

namespace csharp_apis_cinema.DTO
{
    public class GeneroDto
    {
        [StringLength(maximumLength:150)]
        public string Nombre { get; set; }
    }
}
