using AutomapperPoc.DTO;
using AutomapperPoc.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutomapperPoc.Controllers
{
    [ApiController]
    [Route("api/v1/persons")]
    public class PersonController
    {
        private readonly IPersonServices _personServices;

        public PersonController(IPersonServices personServices)
        {
            _personServices = personServices;
        }
        
        [HttpPost]
        public CreatePersonResponse CreatePerson(CreatePersonRequest request)
        {
            return _personServices.CreatePerson(request);
        }
    }
}
