using Tienda.API.Entities;

namespace Tienda.API.DTO.ProductosDTO
{
    public class ProductosDto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }


        public int IdProveedor { get; set; }
    }
}
