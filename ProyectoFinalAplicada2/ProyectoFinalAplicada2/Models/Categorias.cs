using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models
{
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }
        [Required(ErrorMessage = "El nombre no puede estar vacio")]
        [StringLength(maximumLength: 20, MinimumLength = 5, ErrorMessage = "El Nombre esta fuera del rango, Muy corto o muy largo.")]
        public string Nombre { get; set; }

        public Categorias()
        {
            CategoriaId = 0;
            Nombre = string.Empty;
        }
    }
}
