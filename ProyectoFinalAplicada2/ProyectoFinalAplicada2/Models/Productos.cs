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
        public DateTime FechaCreacion { get; set; }
        [Required(ErrorMessage = "La descripción es obligatoria.")]
        public string Descripcion { get; set; }
        [Required]
        [Range(minimum: 1, maximum: 999999999999, ErrorMessage = "Debe seleccionar un proveedor.")]
        public int ProveedorId { get; set; }
        [Required]
        [Range(minimum: 1, maximum: 999999999999, ErrorMessage = "Debe seleccionar una categoría.")]
        public int CategoriaId { get; set; }
        [Required]
        [Range(minimum:1,maximum:999999999999,ErrorMessage = "El costo debe ser mayor a 0.")]
        public decimal Costo { get; set; }
        [Required]
        [Range(minimum: 1, maximum: 999999999, ErrorMessage = "El prociento de ganancia debe ser mayor al 1%")]
        public decimal Ganancia { get; set; }
        [Required]
        [Range(minimum: 1, maximum: 999999999999, ErrorMessage = "El precio debe ser mayor a 0.")]
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public Productos()
        {
            ProductoId = 0;
            FechaCreacion = DateTime.Now;
            Descripcion = string.Empty;
            ProveedorId = 0;
            CategoriaId = 0;
            Costo = 0;
            Ganancia = 0;
            Precio = 0;
            Cantidad = 0;
        }
    }
}
