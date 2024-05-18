using Microsoft.EntityFrameworkCore;
using Videojuegos.Modelos;

namespace Videojuegos.Repositorio
{
    public class RepositorioCategoria : IRepositorioCategoria
    {
        private readonly VJuegosDBContext _context;

        public RepositorioCategoria(VJuegosDBContext context)
        {
            _context = context;
        }

        public async Task<Categoria> Add(Categoria categoria)
        {
            await _context.Categorias.AddAsync(categoria);
            await _context.SaveChangesAsync();
            return categoria;
        }

        public async Task Delete(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);
            if (categoria != null)
            {
                _context.Categorias.Remove(categoria);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Categoria?> Get(int id)
        {
            return await _context.Categorias.FindAsync(id);
        }

        public async Task<List<Categoria>> GetAll()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task<List<Categoria>> GetCategorias()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task Update(int id, Categoria categoria)
        {
            var categoriaActual = await _context.Categorias.FindAsync(id);
            if (categoriaActual != null)
            {
                categoriaActual.Nombre = categoria.Nombre;
                categoriaActual.Descripcion = categoria.Descripcion;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("La categoría no existe en la base de datos.");
            }
        }

    }
}
