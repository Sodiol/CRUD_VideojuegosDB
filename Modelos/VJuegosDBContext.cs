using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Videojuegos.Modelos
{
	public class VJuegosDBContext : DbContext
	{
		public VJuegosDBContext(DbContextOptions<VJuegosDBContext> options) : base(options) 
		{

		}
		public DbSet<Juego> Juegos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

		public DbSet<Venta> Ventas { get; set; }

    }
}
