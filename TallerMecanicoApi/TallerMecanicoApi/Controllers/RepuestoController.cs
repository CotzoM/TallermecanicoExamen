using Microsoft.AspNetCore.Mvc;
using TallerMecanicoApi.Models;

namespace TallerMecanicoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RepuestoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var repuesto = new List<Repuestos>
            {
                new Repuestos { Id = 1, Nombre = "Filtro de aceite", Stock = 10 },
                new Repuestos { Id = 2, Nombre = "Pastillas de freno", Stock = 5 }
            };
            return Ok(repuesto);
        }
    }
}
