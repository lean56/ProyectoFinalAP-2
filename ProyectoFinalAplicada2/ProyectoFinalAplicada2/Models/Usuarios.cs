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
        public DateTime FechaIngreso { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        [StringLength(maximumLength: 15, MinimumLength = 5, ErrorMessage = "El Nombre esta fuera del rango, Muy corto o muy largo.")]
        public string  Nombres { get; set; }
        [Required(ErrorMessage = "El Apellido es obligatorio.")]
        [StringLength(maximumLength: 15, MinimumLength = 5, ErrorMessage = "El Apellido esta fuera del rango, Muy corto o muy largo.")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "El Email es obligatorio")]
        [EmailAddress(ErrorMessage ="Debe ingresar un Email valido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El Usuario es obligatorio.")]
        [StringLength(maximumLength: 15, MinimumLength = 5, ErrorMessage = "El Nombre de usuario esta fuera del rango, muy corto o muy largo!!!")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Debe elegir un nivel de usuario.")]
        [MinLength(5, ErrorMessage = "Debe elegir un nivel de usuario.")]
        public string  NivelUsuario { get; set; }
        [Required(ErrorMessage = "Debe ingresar una contraseña")]
        [StringLength(maximumLength: 10, MinimumLength = 5, ErrorMessage = "La contraseña debe contener al menos 5 caracteres.")]
        public string Contrasena { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombres = string.Empty;
            Email = string.Empty;
            NivelUsuario = string.Empty;
            Usuario = string.Empty;
            Contrasena = string.Empty;
            FechaIngreso = DateTime.Now;
        }
    }
}
