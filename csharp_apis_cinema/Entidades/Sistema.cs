namespace csharp_apis_cinema.Entidades
{
    public class Sistema
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        HashSet<Lenguaje> Lenguajes { get; set; } = new HashSet<Lenguaje>();
        List<SistemaProgramador> SistemasProgramadores { get; set; } = new List<SistemaProgramador>();
    }
}
