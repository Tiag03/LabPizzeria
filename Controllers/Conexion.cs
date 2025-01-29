using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace LabSistemaPizzeria.Controllers
{
    internal class Conexion
    {
        public Conexion() { }

        public SqlConnection GetConection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["SisPizzeria"].ToString());
        }
    }
}
