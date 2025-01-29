using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSistemaPizzeria.Models
{
    internal class UsuariosModel
    {
        public UsuariosModel() { }
        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        public Boolean Activo { get; set; }
        public string UserCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UserUpdate { get; set; } 
        public static DataTable GetUsuarios { get; set; }
    }
}
