using System.ComponentModel.DataAnnotations;

namespace Act15.Models
{
    public class Estudiante
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "El correo no tiene un formato válido.")]
        [StringLength(150)]
        public string Correo { get; set; } = string.Empty;

        [Required(ErrorMessage = "La calificación es obligatoria.")]
        [Range(0, 10, ErrorMessage = "La calificación debe estar entre 0 y 10.")]
        public double Calificacion { get; set; }
    }
}
