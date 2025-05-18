using Microsoft.AspNetCore.Mvc;
using TallerMecanicoApi.Models;

namespace TallerMecanicoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var clientes = new List<Cliente>
            {
                new Cliente { Id = 1, Nombre = "Luis Pérez", Telefono = "555-1234" },
                new Cliente { Id = 2, Nombre = "Marta Gómez", Telefono = "555-5678" }
            };
            return Ok(clientes);
        }
    }
}
