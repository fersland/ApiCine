using AutoMapper;
using csharp_apis_cinema.DTO;
using csharp_apis_cinema.Entidades;

namespace csharp_apis_cinema
{
    public class AuoMapperPerfiles : Profile
    {
        public AuoMapperPerfiles()
        {
            // CINEMA

            CreateMap<GeneroDto, Genero>();
            CreateMap<ActorDto, Actor>();

            CreateMap<PeliculaDto, Pelicula>()
                .ForMember(ent => ent.Generos, dto => // fflush
                dto.MapFrom(campo => campo.Generos.Select(id => new Genero { Id = id })));

            CreateMap<PeliculaActorDto, PeliculaActor>();

            // SISTEMAS

            CreateMap<LenguajeDto, Lenguaje>();
            CreateMap<ProgramadorDto, Programador>();

            CreateMap<SistemaDto, Sistema>()
                .ForMember(ent => ent.Lenguajes, dto =>
                dto.MapFrom(campo => campo.Lenguajes.Select(id => new Lenguaje { Id = id })));
            CreateMap<SistemaProgramadorDto, SistemaProgramador>();
            
        }
    }
}