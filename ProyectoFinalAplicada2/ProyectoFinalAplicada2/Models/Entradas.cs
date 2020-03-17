using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models
{
    public class Entradas
    {
        [Key]
        public int EntradaId { get; set; }
        public DateTime Fecha { get; set; }

        [ForeignKey("EntradaId")]
        public List<EntradasDetalles> Detalle { get; set; }

        public Entradas()
        {
            EntradaId = 0;
            Fecha = DateTime.Now;
            Detalle = new List<EntradasDetalles>();
        }
    }
}
