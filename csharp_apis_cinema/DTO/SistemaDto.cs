using csharp_apis_cinema.Entidades;

namespace csharp_apis_cinema.DTO
{
    public class SistemaDto
    {
        public string Nombre { get; set; } = null!;
        public List<int> Lenguajes { get; set; } = new List<int>();
        public List<SistemaProgramadorDto> SistemasProgramadores { get; set; } = new 
            List<SistemaProgramadorDto>();

    }
}