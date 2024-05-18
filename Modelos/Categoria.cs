using System.ComponentModel.DataAnnotations;

namespace Videojuegos.Modelos
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Es necesario el nombre del juego")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Se debe escribir una descripción")]
        [StringLength(300, ErrorMessage = "Máximo 300 caracteres")]

        public string? Descripcion { get; set; }

        //Propiedad de navegación EF
        virtual public ICollection<Juego>? Juegos { get; set; }
    }
}
