using Microsoft.AspNetCore.Mvc;
using TallerMecanicoApi.Models;


namespace TallerMecanicoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TurnoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var turnos = new List<Turno>
            {
                new Turno { Id = 1, ClienteId = 1, Fecha = DateTime.Today.AddDays(1), Servicio = "Revisión general" },
                new Turno { Id = 2, ClienteId = 2, Fecha = DateTime.Today.AddDays(2), Servicio = "Cambio de aceite" }
            };
            return Ok(turnos);
        }
    }
}
