using System.ComponentModel.DataAnnotations;

namespace Videojuegos.Modelos
{
	public class Juego
	{
		public int Id { get; set; }

        [Required(ErrorMessage ="Es necesario el nombre del juego")]
        [StringLength(100, ErrorMessage ="Máximo 100 caracteres")]
        public string? Nombre { get; set; }

        //[Required(ErrorMessage ="Es necesario definir la categoría")]
       // public string? Categoria { get; set; }

		[Required(ErrorMessage = "Es necesario definir el año de publicación del juego")]
        [Range(1900, int.MaxValue, ErrorMessage = "El año debe ser mayor o igual a 1900")]
        [ValidarAnio(ErrorMessage = "El año no puede ser mayor al año actual")]
        public int Anio { get; set; }

        [Required(ErrorMessage ="Se debe escribir una descripción")]
        [StringLength(300, ErrorMessage ="Máximo 300 caracteres")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage ="Debe incluir el stock del videojuego")]
        public int Stock { get; set; }

        [Required(ErrorMessage ="Debe ingresar el precio del producto")]
        public decimal Precio { get; set; }

        public int? CategoriaId { get; set; }
        virtual public Categoria? Categoria { get; set; }
    }

    public class ValidarAnioAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int anio = Convert.ToInt32(value);
            int anioActual = DateTime.Now.Year;
            return anio <= anioActual;
        }
    }
}
