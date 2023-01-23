using Tienda.API.Entities;
using Tienda.API.DTO.ProductosDTO;

namespace Tienda.API.DTO.ProveedoresDTO
{
    public class ProveedoresDto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Contacto { get; set; }


        public ICollection<ProductosDto>? Productos { get; set; }
    }
}
