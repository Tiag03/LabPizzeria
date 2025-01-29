using LabSistemaPizzeria.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSistemaPizzeria.Controllers
{
    internal class UsuariosControler
    {
        public UsuariosControler() { }
        public void ListarUsuarios()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new Conexion().GetConection())
                {
                    con.Open();

                    string Qry = "select * from Usuarios";
                    using (SqlCommand cmd = new SqlCommand(Qry, con))
                    {
                        new SqlDataAdapter(cmd).Fill(dt);
                        UsuariosModel.GetUsuarios = dt;


                    }

                    con.Close();

                }
            }
            catch (Exception e)


            {


                MessageBox.Show(e.Message, "Listar Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);


            }
        }

        public bool CrearUsuario(UsuariosModel Modelo)
        {
            try
            {
                using (SqlConnection con = new Conexion().GetConection())
                {
                    con.Open();
                    string Qry = "Insert into Usuarios (IdUsuario, Nombre, Password, Rol, Activo, UserCreacion, FechaCreacion) select '" + Modelo.IdUsuario + "','" + Modelo.Nombre + "','" + Modelo.Password + "','" + Modelo.Rol + "','" + Modelo.Activo + "','" + Modelo.UserCreacion + "', getdate()";
                    using (SqlCommand cmd = new SqlCommand(Qry, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();

                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool ActualizarUsuario(UsuariosModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConection())
                {
                    Con.Open();
                  //  string Qry = "Insert into Usuarios (IdUsuario, Nombre, Password, Rol, Activo,UserCreacion,FechaCreacion) select '" + Modelo.IdUsuario + "','" + Modelo.Nombre + "','" + Modelo.Password + "','" + Modelo.Rol + ",'" + Modelo.Activo + "','" + Modelo.UserCreacion + "',getdate()'";
                   // using (SqlCommand cmd = new SqlCommand(Qry, Con))
                    {
                    //    cmd.ExecuteNonQuery();
                    }
                    Con.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
