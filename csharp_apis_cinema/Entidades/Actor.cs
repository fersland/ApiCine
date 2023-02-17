namespace csharp_apis_cinema.Entidades
{
    public class Actor
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int Edad { get; set; }

        public List<PeliculaActor> PeliculasActores { get; set; } = new List<PeliculaActor>();
    }
}
