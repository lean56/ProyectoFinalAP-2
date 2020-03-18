using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models
{
    public class PagosConsulta
    {
        [Key]
        public int PagoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public decimal MontoPago { get; set; }

        public PagosConsulta()
        {
            PagoId = 0;
            Fecha = DateTime.Now;
            Cliente = string.Empty;
            MontoPago = 0;
        }
    }
}
