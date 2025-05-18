using Microsoft.AspNetCore.Mvc;
using TallerMecanicoApi.Models;


namespace TallerMecanicoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacturaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var facturas = new List<Factura>
            {
                new Factura { Id = 1, ClienteId = 1, Detalle = "Cambio de aceite y filtro", Total = 30.00M },
                new Factura { Id = 2, ClienteId = 2, Detalle = "Revisión completa", Total = 50.00M }
            };
            return Ok(facturas);
        }
    }
}
