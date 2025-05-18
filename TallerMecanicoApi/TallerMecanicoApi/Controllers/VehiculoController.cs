using Microsoft.AspNetCore.Mvc;
using TallerMecanicoApi.Models;

namespace TallerMecanicoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiculoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var vehiculos = new List<Vehiculos>
            {
                new Vehiculos { Id = 1, Placa = "ABC123", Marca = "Toyota", Modelo = "Corolla", Año = 2020 },
                new Vehiculos { Id = 2, Placa = "XYZ789", Marca = "Honda", Modelo = "Civic", Año = 2021 }
            };
            return Ok(vehiculos);
        }
    }
}
