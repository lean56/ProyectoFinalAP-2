using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models.ModelsForQueries
{
    public class FacturasConsulta
    {
        [Key]
        public int FacturaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public decimal Total { get; set; }

        public FacturasConsulta()
        {
            FacturaId = 0;
            Fecha = DateTime.Now;
            Cliente = string.Empty;
            Total = 0;
        }
    }
}
