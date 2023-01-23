using Microsoft.EntityFrameworkCore;
using Tienda.API.Entities;

namespace Tienda.API.Context
{
    public class TiendaContext : DbContext
    {
        public TiendaContext(DbContextOptions options) : base(options){}


        public DbSet<ProductosEntity> Productos{ get; set; }
        public DbSet<ProveedoresEntity> Proveedores { get; set;}
    }
}
