namespace csharp_apis_cinema.DTO
{
    public class PeliculaDto
    {
        public string Titulo { get; set; } = null!;
        public bool EnCines { get; set; }
        public DateTime FechaEstreno { get; set; }

        public List<int> Generos { get; set; } = new List<int>();
        public List<PeliculaActorDto> PeliculasActores { get; set; } = new List<PeliculaActorDto>(); 
    }
}
