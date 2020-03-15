﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }
        public int ClienteId { get; set; }
        public string Usuario { get; set; }
        public int ProductoId { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }


        public virtual List<FacturaDetalles> Detalle { get; set; }

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