using AutoMapper;
using AutomapperPoc.Domain;
using AutomapperPoc.DTO;

namespace AutomapperPoc.Mapper
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<CreatePersonRequest, Person>();
            CreateMap<Person, CreatePersonResponse>();
        }
    }
}
