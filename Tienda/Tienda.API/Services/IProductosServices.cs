using Tienda.API.DTO.ProductosDTO;
using Tienda.API.Entities;

namespace Tienda.API.Services
{
    public interface IProductosServices
    {
        Task<List<ProductosDto>> ObtenerProductos();
        void CrearProducto(ProductosDto Producto);
    }
}
