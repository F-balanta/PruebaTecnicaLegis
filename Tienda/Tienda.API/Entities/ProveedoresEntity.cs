namespace Tienda.API.Entities
{
    public class ProveedoresEntity
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Contacto { get; set; }


        public ICollection<ProductosEntity>? Productos { get; set; }
    }
}
