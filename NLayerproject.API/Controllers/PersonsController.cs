using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerproject.Core.Models;
using NLayerproject.Core.Services;
using System.Threading.Tasks;

namespace NLayerproject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IService<Person> _personService;
        public PersonsController(IService<Person> service)
        {
            _personService = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var persons=await _personService.GetAllAsync();
            return Ok(persons);
        }
        [HttpPost]
        public async Task<IActionResult> Save(Person person)
        {
            var newperson= await _personService.AddAsync(person);
            return Ok(newperson);
        }
    }
}
