using Microsoft.AspNetCore.Mvc;
using Tienda.API.Entities;
using Tienda.API.Services;

namespace Tienda.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProveedoresController : Controller
    {
        private readonly IProveedoresServices _proveedoresServices;

        public ProveedoresController(IProveedoresServices proveedoresServices)
        {
            _proveedoresServices = proveedoresServices;
        }



        [HttpGet("Obtener")]
        public async Task<ActionResult<List<ProveedoresEntity>>> ObtenerProductos()
        {
            return await _proveedoresServices.ObtenerProveedores();
        }


        [HttpPost("Crear")]
        public IActionResult CrearProducto(ProveedoresEntity producto)
        {
            _proveedoresServices.CrearProveedor(producto);
            return Ok();
        }
    }
}
