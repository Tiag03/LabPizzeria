using LabSistemaPizzeria.Controllers;
using LabSistemaPizzeria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSistemaPizzeria.Views
{
      
    public partial class FRMUsuarios : Form
    {
        UsuariosModel Modelo;
        public FRMUsuarios()
        {
            InitializeComponent();
        }

        void CargarUsuarios()
        {
            new UsuariosControler().ListarUsuarios();
            dgvDatos.DataSource = UsuariosModel.GetUsuarios;
            dgvDatos.Columns["IdUsuario"].Width = 150;
            dgvDatos.Columns["Nombre"].Width = 300;
            dgvDatos.Columns["password"].Width = 150;
        }

        void Salvar()
        {
            Modelo = new UsuariosModel();
            Modelo.IdUsuario = txtIdUsuario.Text;
            Modelo.Nombre = txtNombre.Text;
            Modelo.Password = txtPassword.Text;
            Modelo.Rol = txtRol.Text;
            Modelo.Activo = cbActivo.Checked;
           

            Modelo.UserCreacion = "LPerez";
            Modelo.UserUpdate = "Lperez";

            
                if (new UsuariosControler().CrearUsuario(Modelo) == true)
                {
                    MessageBox.Show("Registro creado exitosamente");
                    CargarUsuarios();
                    this.Close();
                }
            
            else
            {
                if (new UsuariosControler().ActualizarUsuario(Modelo) == true)
                {
                    MessageBox.Show("Registro Actualizado Exitosamente");
                    CargarUsuarios();
                    this.Close();

                }
            }
        }

        private void FRMUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
