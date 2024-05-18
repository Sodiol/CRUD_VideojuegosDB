using Videojuegos.Modelos;

namespace Videojuegos.Repositorio
{
    public interface IRepositorioCategoria
    {
        Task<List<Categoria>> GetAll();
        Task<Categoria?> Get(int id);

        Task<List<Categoria>> GetCategorias();

        Task<Categoria> Add(Categoria categoria);

        Task Update(int id, Categoria categoria);

        Task Delete(int id);
    }
}