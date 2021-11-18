using System;
using AutoMapper;
using AutomapperPoc.Domain;
using AutomapperPoc.DTO;

namespace AutomapperPoc.Services
{
    public interface IPersonServices
    {
        CreatePersonResponse CreatePerson(CreatePersonRequest request);
    }
    
    public class PersonServices : IPersonServices
    {
        private readonly IMapper _mapper;
        
        public PersonServices(IMapper mapper)
        {
            _mapper = mapper;
        }

        public CreatePersonResponse CreatePerson(CreatePersonRequest request)
        {
            try
            {
                var person = _mapper.Map<Person>(request);

                person.Name = "";
                
                return _mapper.Map<CreatePersonResponse>(person);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
