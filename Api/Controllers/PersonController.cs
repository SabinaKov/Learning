using BusinesLogic;
using BusinesLogic.Models;
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
            PeopleData peopleData = new PeopleData();
            return peopleData.GetPeople();
        }
    }
}
