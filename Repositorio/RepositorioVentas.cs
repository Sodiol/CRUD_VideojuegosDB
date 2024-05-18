using Microsoft.EntityFrameworkCore;

using Videojuegos.Modelos;

namespace Videojuegos.Repositorio
{
    public class RepositorioVentas : IRepositorioVentas
    {
        private readonly VJuegosDBContext _context;

        public RepositorioVentas(VJuegosDBContext context)
        {
            _context = context;
        }

        public async Task<Venta> Add(Venta ventas)
        {
            await _context.Ventas.AddAsync(ventas);
            await _context.SaveChangesAsync();
            return ventas;
        }

        public async Task Delete(int id)
        {
            var venta = await _context.Ventas.FindAsync(id);
            if (venta != null)
            {
                _context.Ventas.Remove(venta);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Venta?> Get(int id)
        {
            return await _context.Ventas.FindAsync(id);
        }

        public async Task<List<Venta>> GetAll()
        {
            return await _context.Ventas.ToListAsync();
        }

        public async Task<List<Venta>> GetVentas()
        {
            return await _context.Ventas.ToListAsync();
        }

        public async Task Update(int id, Venta ventas)
        {
            var ventaActual = await _context.Ventas.FindAsync(id);
            if (ventaActual != null)
            {
                ventaActual.Nombre = ventas.Nombre;
                ventaActual.Categoria = ventas.Categoria;
                ventaActual.Descripcion = ventas.Descripcion;
                ventaActual.FechaVenta = ventas.FechaVenta;
                ventaActual.PrecioVenta = ventas.PrecioVenta;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("La venta no existe en la base de datos.");
            }
        }
    }
}
