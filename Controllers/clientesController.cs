using LabSistemaPizzeria.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSistemaPizzeria.Controllers
{
    internal class clientesController
    {
        public clientesController() { }
        public void ListarCliente()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConection())
                {
                    Con.Open();

                    string qry = "execute GestionarCliente 4 ";
                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                        LeerDatos.Fill(dt);
                    }
                    Con.Close();

                    ClientesModel.GetClientes = dt;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Listar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public bool CrearCliente(ClientesModel Modelo)
        {
            try
            {

                using (SqlConnection Con = new Conexion().GetConection())
                {
                    Con.Open();

                    string qry = "execute GestionarCliente 1,'" + Modelo.IdCliente + "','" + Modelo.Nombre + "','" + Modelo.Apellido + "','" + Modelo.DNI + "','" + Modelo.Telefono + "','" + Modelo.Correo + "','" + Modelo.Activo + "','" + Modelo.UserCreacion + "'";

                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    Con.Close();
                }
                return true;
            }
            catch (Exception errores)
            {
                MessageBox.Show(errores.Message, "CREAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }

        public bool ActualizarCliente(ClientesModel Modelo)
        {
            try
            {

                using (SqlConnection Con = new Conexion().GetConection())
                {
                    Con.Open();
                    string qry = "execute GestionarCliente 2,'" + Modelo.IdCliente + "','" + Modelo.Nombre + "','" + Modelo.Apellido + "','" + Modelo.DNI + "','" + Modelo.Telefono + "','" + Modelo.Correo + "','" + Modelo.Activo + "'";
                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();
                    }
                    Con.Close();
                }
                return true;
            }
            catch (Exception errores)
            {
                MessageBox.Show(errores.Message, "Actualizar", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }
        public bool EliminarCliente(ClientesModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConection())
                {
                    Con.Open();
                    string qry = "execute GestionarCliente 3,'" + Modelo.IdCliente + "','" + Modelo.Nombre + "','" + Modelo.Apellido + "','" + Modelo.DNI + "','" + Modelo.Telefono + "','" + Modelo.Correo + "','" + Modelo.Activo + "'";


                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        cmd.CommandTimeout = 600;
                        cmd.ExecuteNonQuery();

                    }

                    Con.Close();
                }
                return true;
            }
            catch (Exception errores)
            {
                MessageBox.Show(errores.Message, "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }
    }
}
