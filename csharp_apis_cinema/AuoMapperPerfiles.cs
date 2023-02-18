using AutoMapper;
using csharp_apis_cinema.DTO;
using csharp_apis_cinema.Entidades;

namespace csharp_apis_cinema
{
    public class AuoMapperPerfiles : Profile
    {
        public AuoMapperPerfiles()
        {
            CreateMap<GeneroDto, Genero>();
            CreateMap<ActorDto, Actor>();

            CreateMap<PeliculaDto, Pelicula>()
                .ForMember(ent => ent.Generos, dto => // 
                dto.MapFrom(campo => campo.Generos.Select(id => new Genero { Id = id })));

            CreateMap<PeliculaActorDto, PeliculaActor>();
        }
    } 
}