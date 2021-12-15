using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public List<PersonModel> Get()
        {
           List<PersonModel> people = new List<PersonModel>();
                people.Add(new PersonModel {FirstName = "Sabina", LastName = "Kovarikova", Age = 25, IsAlive = true });
                people.Add(new PersonModel {FirstName = "Miroslav", LastName = "Vaculka", Age = 30, IsAlive = true });
            return people;
        }
    }
}
