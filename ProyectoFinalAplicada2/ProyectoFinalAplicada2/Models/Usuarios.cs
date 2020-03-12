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
        public string  Nombres { get; set; }
        public string  NivelUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombres = string.Empty;
            NivelUsuario = string.Empty;
            Usuario = string.Empty;
            Contraseña = string.Empty;
            FechaIngreso = DateTime.Now;
        }
    }
}
