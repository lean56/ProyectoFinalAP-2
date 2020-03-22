using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models
{
    public class Proveedores
    {
        [Key]
        public int ProveedorId { get; set; }
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        public string Nombre { get; set; }
        [DataType(DataType.PhoneNumber, ErrorMessage = "Número de Teléfono Invalido.")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Número de Teléfono Invalido.")]
        [Required(ErrorMessage = "El Teléfono es obligatorio.")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "La dirección es obligatoria.")]
        public string Direccion { get; set; }

        public Proveedores()
        {
            ProveedorId = 0;
            Fecha = DateTime.Now;
            Nombre = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
        }
    }
}
