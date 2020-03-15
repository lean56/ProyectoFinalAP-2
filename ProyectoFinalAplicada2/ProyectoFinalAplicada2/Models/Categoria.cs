using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [Required(ErrorMessage = "El nombre no puede estar vacio")]
        public string Nombre { get; set; }

        public Categoria()
        {
            CategoriaId = 0;
            Nombre = string.Empty;
        }
    }
}
