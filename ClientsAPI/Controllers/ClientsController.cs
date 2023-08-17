using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Clients>>> GetClients()
        {
            return new List<Clients>
            {
            new Clients
            {
                Id = 1,
                Name = "Gabriel Amaru Recabarren Galleguillos",
                Phone = "945284756",
                Email= "gabriel.recabarren@gmail.com",
                CountryCode = 56

                }
            };
        }
    }
}
