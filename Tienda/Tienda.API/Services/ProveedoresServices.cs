using Microsoft.EntityFrameworkCore;
using Tienda.API.Context;
using Tienda.API.Entities;

namespace Tienda.API.Services
{
    public class ProveedoresServices : IProveedoresServices
    {
        private readonly TiendaContext _context;

        public ProveedoresServices(TiendaContext context)
        {
            _context = context;
        }

        public async Task<List<ProveedoresEntity>> ObtenerProveedores()
        {
            List<ProveedoresEntity> proveedores = await _context.Proveedores.ToListAsync();
            if (proveedores == null)
            {
                proveedores = new List<ProveedoresEntity>();
            }
            return proveedores;
        }

        public void CrearProveedor(ProveedoresEntity proveedor)
        {
            _context.Proveedores.AddAsync(proveedor);
            _context.SaveChangesAsync();
        }
    }
}
