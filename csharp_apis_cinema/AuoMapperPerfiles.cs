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
        }
    }
}
