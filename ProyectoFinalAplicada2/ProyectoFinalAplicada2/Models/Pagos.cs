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
        public int ClienteId { get; set; }
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
