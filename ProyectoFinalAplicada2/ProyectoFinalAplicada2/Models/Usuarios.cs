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
        [MinLength(3, ErrorMessage = "Este nombre es muy corto, debe elegir un nombre más largo.")]
        [MaxLength(20, ErrorMessage = "Este nombre es muy largo, debe elegir un nombre más corto.")]
        public string  Nombres { get; set; }
        [Required(ErrorMessage = "El Apellido es obligatorio.")]
        [MinLength(3, ErrorMessage = "El o los apellidos son muy cortos.")]
        [MaxLength(20, ErrorMessage = "El o los apellidos son muy largos.")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "El Email es obligatorio")]
        [EmailAddress(ErrorMessage ="Debe ingresar un Email valido.")]
        [MaxLength(40, ErrorMessage = "Este correo es muy largo.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El Usuario es obligatorio.")]
        [MinLength(3, ErrorMessage = "El usuario es muy corto, bebe contener al menos 3 caracteres.")]
        [MaxLength(20, ErrorMessage = "El Usuario es muy largo.")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Debe elegir un nivel de usuario.")]
        [MinLength(5, ErrorMessage = "Debe elegir un nivel de usuario.")]
        public string  NivelUsuario { get; set; }
        [Required(ErrorMessage = "Debe ingresar una contraseña")]
        [MinLength(5, ErrorMessage = "La contraseña debe contener al menos 5 caracteres.")]
        [MaxLength(30, ErrorMessage = "La contraseña es muy larga.")]
        public string Contrasena { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Email = string.Empty;
            NivelUsuario = string.Empty;
            Usuario = string.Empty;
            Contrasena = string.Empty;
            FechaIngreso = DateTime.Now;
        }
    }
}
