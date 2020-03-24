using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models.ModelsForQueries
{
    public class ProductosConsulta
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descrpcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Categoria { get; set; }
        public string Proveedor { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public ProductosConsulta()
        {
            ProductoId = 0;
            Descrpcion = string.Empty;
            FechaCreacion = DateTime.Now;
            Categoria = string.Empty;
            Proveedor = string.Empty;
            Precio = 0;
            Cantidad = 0;
        }
    }
}
