using Microsoft.AspNetCore.Mvc;
using TallerMecanicoApi.Models;

namespace TallerMecanicoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MecanicoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var mecanicos = new List<Mecanico>
            {
                new Mecanico { Id = 1, Nombre = "Carlos López", Especialidad = "Frenos" },
                new Mecanico { Id = 2, Nombre = "Ana Ramírez", Especialidad = "Motor" }
            };
            return Ok(mecanicos);
        }
    }
}
