using Videojuegos.Modelos;

namespace Videojuegos.Repositorio
{
    public interface IRepositorioJuego
    {
        Task<List<Juego>> GetAll();
        Task<Juego?> Get(int id);

        Task<List<Categoria>> GetCategorias();

        Task<Juego> Add(Juego juego);

        Task Update(int id, Juego juego);

        Task Delete(int id);
    }
}
