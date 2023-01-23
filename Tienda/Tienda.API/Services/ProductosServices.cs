using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using Tienda.API.Context;
using Tienda.API.DTO.ProductosDTO;
using Tienda.API.Entities;

namespace Tienda.API.Services
{
    public class ProductosServices : IProductosServices
    {
        private readonly TiendaContext _context;
        private readonly IMapper _mapper;

        public ProductosServices(TiendaContext context, IMapper mapper)
        {
            _context= context;
            _mapper = mapper;
        }


        public async Task<List<ProductosDto>> ObtenerProductos()
        {
            List<ProductosEntity> productos = await _context.Productos.ToListAsync();
            List<ProductosDto> listaProductos = _mapper.Map<List<ProductosDto>>(productos);

            return listaProductos;
        }

        public void CrearProducto(ProductosDto producto)
        {
            var productoEntity = _mapper.Map<ProductosEntity>(producto);

            _context.Productos.AddAsync(productoEntity);
            _context.SaveChangesAsync();
        }

    }
}
