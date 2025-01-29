using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabSistemaPizzeria.Models;
using System.Reflection;

namespace LabSistemaPizzeria.Controllers
{
    internal class ProductosController
    {
        public ProductosController() { }
        public void ListarProductos()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConection())
                {
                    Con.Open();

                    string qry = "select * from Productos ";
                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                        LeerDatos.Fill(dt);
                    }
                    Con.Close();

                    ProductosModel.GetProducto = dt;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Listar Producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public bool CrearProducto(ProductosModel Modelo)
        {
            try
            {

                using (SqlConnection Con = new Conexion().GetConection())
                {
                    Con.Open();

                    string qry = "execute InsertarProducto 1,'" + Modelo.ProductoID + "','" + Modelo.Nombre + "','" + Modelo.Descripcion + "','" + Modelo.Precio + "','" + Modelo.Activo + "','" + Modelo.UserCreacion + "'";


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

        public bool ActualizarProductos(ProductosModel Modelo)
        {
            try
            {

                using (SqlConnection Con = new Conexion().GetConection())
                {
                    Con.Open();
                    string qry = "execute InsertarProducto 2,'" + Modelo.ProductoID + "','" + Modelo.Nombre + "','" + Modelo.Nombre + "','" + Modelo.Descripcion + "','" + Modelo.Precio + "','" + Modelo.Activo + "'";
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
        public bool EliminarProducto(ProductosModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConection())
                {
                    Con.Open();
                    string qry = "execute InsertarProducto 3,'" + Modelo.ProductoID + "','" + Modelo.Nombre + "','" + Modelo.Nombre + "','" + Modelo.Descripcion + "','" + Modelo.Precio + "','" + Modelo.Activo + "'";


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
                MessageBox.Show(errores.Message, "Eliminar Producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }
    }
}
