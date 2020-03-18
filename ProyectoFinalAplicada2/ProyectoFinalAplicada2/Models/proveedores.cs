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
        [Required(ErrorMessage = "El nombre del proveedor no puede estar vacío!")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La dirección del proveedor no puede estar vacío!")]
        public string Direccion { get; set; }
        [DataType(DataType.PhoneNumber)]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Telefono Invalido")]
        [Required(ErrorMessage = "El teléfono del proveedor no puede estar vacío!")]
        public string Telefono { get; set; }

        public Proveedores()
        {
            ProveedorId = 0;
            Nombre = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
        }
    }
}
