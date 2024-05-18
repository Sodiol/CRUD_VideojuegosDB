using System.ComponentModel.DataAnnotations;

namespace Videojuegos.Modelos
{
    public class Venta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Se requiere el nombre del juego")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Se requiere la categoría del juego")]
        public string? Categoria { get; set; }

        [Required(ErrorMessage = "Se requiere la descripción del juego")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Se requiere la fecha de venta")]
        public DateTime FechaVenta { get; set; }

        [Required(ErrorMessage = "Se requiere el precio de venta")]
        public decimal PrecioVenta { get; set; }

        public Juego Juego { get; set; }

        //Propiedad de navegación EF
        virtual public ICollection<Juego>? Juegos { get; set; }
    }
}
