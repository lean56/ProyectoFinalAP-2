using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }
        public int ClienteId { get; set; }
        [Range(minimum: 1, maximum: 999999999999, ErrorMessage = "Debe seleccionar un Cliente.")]
        public string Usuario { get; set; }
        public int ProductoId { get; set; }
        //[Range(minimum:1,maximum:1000000,ErrorMessage ="El total debe se mayor a cero")]
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }

        [ForeignKey("FacturaId")]

        public List<FacturaDetalles> Detalle { get; set; }

        public Facturas()
        {
            FacturaId = 0;
            ClienteId = 0;
            Usuario = string.Empty;
            ProductoId = 0;
            Total = 0;
            Fecha = DateTime.Now;
            this.Detalle = new List<FacturaDetalles>();
        }
    }
}
