using DevHair.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevHair.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;

        public ClientController(ILogger<ClientController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) 
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post(ClientModel client) 
        {
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, ClientModel client)
        {
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return NoContent();
        }























    }
}
