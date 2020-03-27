using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        [MinLength(3, ErrorMessage = "Este nombre es muy corto, debe elegir un nombre más largo.")]
        [MaxLength(50, ErrorMessage = "Este nombre es muy largo, debe elegir un nombre más corto.")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "La Cedula es obligatoria.")]
        [StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "Cedula invalida.")]
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        [Required(ErrorMessage = "El Email es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe ingresar un Email valido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "La Dirección es obligatoria.")]
        [MinLength(10, ErrorMessage = "Esta direccion es muy corta.")]
        [MaxLength(40, ErrorMessage = "Este direccion es muy larga.")]
        public string Direccion { get; set; }
        public decimal Deuda { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            Fecha = DateTime.Now;
            Nombres = string.Empty;
            Cedula = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            Direccion = string.Empty;
            Email = string.Empty;
            Deuda = 0;
        }
    }
}
