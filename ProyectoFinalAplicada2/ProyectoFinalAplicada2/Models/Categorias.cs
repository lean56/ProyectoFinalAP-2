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
        [MinLength(3, ErrorMessage = "Este nombre es muy corto, debe elegir un nombre más largo.")]
        [MaxLength(20, ErrorMessage = "Este nombre es muy largo, debe elegir un nombre más corto.")]
        public string Nombre { get; set; }

        public Categorias()
        {
            CategoriaId = 0;
            Nombre = string.Empty;
        }
    }
}
