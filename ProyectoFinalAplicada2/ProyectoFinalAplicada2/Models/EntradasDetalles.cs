using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models
{
    public class EntradasDetalles
    {
        [Key]
        public int EntradaDetalleId { get; set; }
        public int EntradaId { get; set; }
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }

        public EntradasDetalles()
        {
            EntradaDetalleId = 0;
            EntradaId = 0;
            ProductoId = 0;
            Descripcion = string.Empty;
            Cantidad = 0;
        }

        public EntradasDetalles(int entradaDetalleId, int entradaId, int productoId, string descripcion, int cantidad)
        {
            EntradaDetalleId = entradaDetalleId;
            EntradaId = entradaId;
            ProductoId = productoId;
            Descripcion = descripcion;
            Cantidad = cantidad;
        }
    }
}
