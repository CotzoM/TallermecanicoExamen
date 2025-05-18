using Microsoft.AspNetCore.Mvc;
using TallerMecanicoApi.Models;

namespace TallerMecanicoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServicioController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var servicios = new List<Servicio>
            {
                new Servicio { Id = 1, Nombres = "Cambio de aceite", Precio = 25.00M },
                new Servicio { Id = 2, Nombres = "Alineación", Precio = 40.00M }
            };
            return Ok(servicios);
        }
    }
}
