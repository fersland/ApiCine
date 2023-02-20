using System.Text.Json.Serialization;

namespace csharp_apis_cinema.DTO
{
    public class SistemaProgramadorDto
    {
        public int ProgramadorId { get; set; }
        public string Empresa { get; set; } = null!;
        public decimal Precio { get; set; }       

    }
}