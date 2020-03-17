using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        [Required(ErrorMessage = "El campo Descripcion obligatorio.")]
        public string Descripcion { get; set; }
        [Range(minimum:1,maximum:1000000,ErrorMessage ="El costo debe ser mayor a cero")]
        public decimal Costo { get; set; }
        [Range(minimum: 1, maximum: 1000000, ErrorMessage = "El Precio debe ser mayor a cero")]
        public decimal Precio { get; set; }
        public decimal Ganancia { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Categoria { get; set; }
        public int Cantidad { get; set; }

        public Productos()
        {
            ProductoId = 0;
            Descripcion = string.Empty;
            Costo = 0;
            Precio = 0;
            Ganancia = 0;
            FechaCreacion = DateTime.Now;
            Categoria = 0;
            Cantidad = 0;
        }
    }
}
