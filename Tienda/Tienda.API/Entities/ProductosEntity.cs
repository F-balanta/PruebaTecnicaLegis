namespace Tienda.API.Entities
{
    public class ProductosEntity
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }


        public int ProveedorId { get; set; }
        public ProveedoresEntity? Proveedores { get; set; }
    }
}
