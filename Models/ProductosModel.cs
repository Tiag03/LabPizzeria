using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSistemaPizzeria.Models
{
    internal class ProductosModel
    {
        public ProductosModel() { }
        public string ProductoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Decimal Precio { get; set; }
        public Boolean Activo {  get; set; }
        public string UserCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UserUpdate { get; set; }
        public static DataTable GetProducto {  get; set; }

    }
}
