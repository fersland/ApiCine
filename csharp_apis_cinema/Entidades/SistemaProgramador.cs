namespace csharp_apis_cinema.Entidades
{
    public class SistemaProgramador
    {
        public int SistemaId { get; set; }
        public Sistema Sistema { get; set; } = null!;

        public int ProgramadorId { get; set; }
        public Programador Programador { get; set; } = null!;

        public string Empresa { get; set; } = null!;
        public decimal Precio { get; set; }
    }
}
