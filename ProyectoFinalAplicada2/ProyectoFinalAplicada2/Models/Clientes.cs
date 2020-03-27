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
        [StringLength(maximumLength: 25, MinimumLength = 5, ErrorMessage = "El Nombre esta fuera del rango, Muy corto o muy largo.")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "La Cedula es obligatoria.")]
        [StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "Cedula invalida.")]
        public string Cedula { get; set; }
        [DataType(DataType.PhoneNumber, ErrorMessage = "Número de Teléfono Invalido.")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Número de Teléfono Invalido.")]
        [Required(ErrorMessage = "El Teléfono es obligatorio.")]
        public string Telefono { get; set; }
        [DataType(DataType.PhoneNumber, ErrorMessage = "Número de celular Invalido.")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Número de celular Invalido.")]
        [Required(ErrorMessage = "El Celular es obligatorio.")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "El Email es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe ingresar un Email valido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "La Dirección es obligatoria.")]
        [StringLength(maximumLength: 25, MinimumLength = 5, ErrorMessage = "La Dirección esta fuera del rango, Muy corta o muy larga.")]
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
