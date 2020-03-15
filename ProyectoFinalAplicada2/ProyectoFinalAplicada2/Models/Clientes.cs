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
        [Required(ErrorMessage = "El nombre del cliente no puede estar vacío!")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El cedula del cliente no puede estar vacía!")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "La dirección del cliente no puede estar vacía!")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El teléfono del cliente no puede estar vacía!")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El celular del cliente no puede estar vacía!")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "El correo electrónico del cliente no puede esta vacío!")]
        public string Email { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Deuda { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            Nombres = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            Email = string.Empty;
            Fecha = DateTime.Now;
            Deuda = 0;
        }
    }
}
