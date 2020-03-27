using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models
{
    public class Pagos
    {
        [Key]
        public int PagoId { get; set; }
        public DateTime Fecha { get; set; }
        [Required]
        [Range(minimum: 1, maximum: 999999999999, ErrorMessage = "Debe seleccionar un cliente.")]
        public int ClienteId { get; set; }
        [Required]
        [Range(minimum: 0, maximum: 9999999999999, ErrorMessage = "El monto a pagar debe ser mayor a 0")]
        public decimal MontoPago { get; set; }

        public Pagos()
        {
            PagoId = 0;
            Fecha = DateTime.Now;
            ClienteId = 0;
            MontoPago = 0;
        }
    }
}
