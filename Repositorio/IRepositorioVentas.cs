using Videojuegos.Modelos;

namespace Videojuegos.Repositorio
{
    public interface IRepositorioVentas
    {
        Task<List<Venta>> GetAll();
        Task<Venta?> Get(int id);

        Task<List<Venta>> GetVentas();

        Task<Venta> Add(Venta venta);

        Task Update(int id, Venta venta);

        Task Delete(int id);
    }
}
