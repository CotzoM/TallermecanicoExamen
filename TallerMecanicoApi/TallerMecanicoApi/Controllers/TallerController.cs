using Microsoft.AspNetCore.Mvc;
using TallerMecanicoApi.Models;


namespace TallerMecanicoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TallerController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var taller = new Taller
            {
                Nombre = "Taller El Buen Mecánico",
                Direccion = "Calle Principal #123, Ciudad Taller",
                Telefono = "555-9090"
            };
            return Ok(taller);
        }
    }
}
