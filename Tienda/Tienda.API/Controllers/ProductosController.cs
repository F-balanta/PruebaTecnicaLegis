using Microsoft.AspNetCore.Mvc;
using Tienda.API.DTO.ProductosDTO;
using Tienda.API.Entities;
using Tienda.API.Services;

namespace Tienda.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly IProductosServices _productosServices;

        public ProductosController(IProductosServices productosServices)
        {
            _productosServices = productosServices;
        }


        [HttpGet("Obtener")]
        public async Task<ActionResult<List<ProductosDto>>> ObtenerProductos()
        {
            return await _productosServices.ObtenerProductos();
        }


        [HttpPost("Crear")]
        public  IActionResult CrearProducto(ProductosDto producto)
        {
            _productosServices.CrearProducto(producto);
            return Ok();
        }
    }
}
