using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSistemaPizzeria.Models
{
    internal class ClientesModel
    {
        public ClientesModel() { }
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI {  get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public Boolean Activo { get; set; }
        public string UserCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UserUpdate { get; set; }
        public static DataTable GetClientes {  get; set; }
    }
}
