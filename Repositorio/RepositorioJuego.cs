using Microsoft.EntityFrameworkCore;
using Videojuegos.Modelos;

namespace Videojuegos.Repositorio
{
    public class RepositorioJuego : IRepositorioJuego
    {
        private readonly VJuegosDBContext _context;

        public RepositorioJuego(VJuegosDBContext context)
        {
            _context = context;
        }

        public async Task<Juego> Add(Juego juego)
        {
            await _context.Juegos.AddAsync(juego);
            await _context.SaveChangesAsync();
            return juego;
        }

        public async Task Delete(int id)
        {
            var persona = await _context.Juegos.FindAsync(id);
            if (persona != null)
            {
                _context.Juegos.Remove(persona);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Juego?> Get(int id)
        {
            return await _context.Juegos.FindAsync(id);
        }

        public async Task<List<Juego>> GetAll()
        {
            return await _context.Juegos.Include(c => c.Categoria).ToListAsync();
        }

        public async Task<List<Categoria>> GetCategorias()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task Update(int id, Juego juego)
        {
            var personaactual = await _context.Juegos.FindAsync(id);
            if (personaactual != null)
            {
                personaactual.Nombre = juego.Nombre;
                personaactual.Categoria = juego.Categoria;
                personaactual.Anio = juego.Anio;
                personaactual.Descripcion = juego.Descripcion;
                personaactual.Stock = juego.Stock;
                personaactual.Precio = juego.Precio;
                await _context.SaveChangesAsync();
            }
        }

    }
}
