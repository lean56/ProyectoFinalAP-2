using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada2.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "El campo Nombres obligatorio.")]

        public string  Nombres { get; set; }
        [Required(ErrorMessage = "El campo Correo electronico es obligatorio.")]
        public string Email { get; set; }

        public string  NivelUsuario { get; set; }
        [Required(ErrorMessage = "El campo Usuario es obligatorio.")]

        public string Usuario { get; set; }
        [Required(ErrorMessage = "El campo Contraseña es obligatorio.")]

        public string Contraseña { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombres = string.Empty;
            Email = string.Empty;
            NivelUsuario = string.Empty;
            Usuario = string.Empty;
            Contraseña = string.Empty;
            FechaIngreso = DateTime.Now;
        }
    }
}
