namespace csharp_apis_cinema.Entidades
{
    public class Programador
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int Edad { get; set; }

        public List<SistemaProgramador> SistemasProgramadores { get; set; } = new List<SistemaProgramador>();

    }
}
