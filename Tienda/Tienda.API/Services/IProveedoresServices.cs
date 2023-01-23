using Tienda.API.Entities;

namespace Tienda.API.Services
{
    public interface IProveedoresServices
    {
        Task<List<ProveedoresEntity>> ObtenerProveedores();
        void CrearProveedor(ProveedoresEntity Producto);
    }
}
