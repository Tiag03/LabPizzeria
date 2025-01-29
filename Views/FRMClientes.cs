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
    public partial class FRMClientes : Form
    {
        string Modo = "";
        ClientesModel Modelo;


        public FRMClientes()
        {
            InitializeComponent();
            Modo = "Agregando";
            lblModo.Text = Modo;
        }
        public FRMClientes(string IdCliente)
        {
            InitializeComponent();
            Modo = "Editando";
            txtIdCliente.Text = IdCliente;
            txtIdCliente.Enabled = false;

            foreach (DataRow Fila in UsuariosModel.GetUsuarios.Rows)
            {
                if (Fila["IdCliente"].ToString() == IdCliente)
                {
                    txtNombre.Text = Fila["Nombre"].ToString();
                    txtApellido.Text = Fila["Apellido"].ToString();
                    txtDNI.Text = Fila["DNI"].ToString();
                    txtTelefono.Text = Fila["Telefono"].ToString();
                    txtCorreo.Text = Fila["Correo"].ToString();
                    cbActivo.Checked = bool.Parse(Fila["Activo"].ToString());
                    break;
                }
            }
        }

        void Salvar()
        {
            Modelo = new ClientesModel();
            Modelo.IdCliente = txtIdCliente.Text;
            Modelo.Nombre = txtNombre.Text;
            Modelo.Apellido = txtApellido.Text;
            Modelo.DNI = txtDNI.Text;
            Modelo.Telefono = txtTelefono.Text;
            Modelo.Correo = txtCorreo.Text;
            Modelo.Activo = cbActivo.Checked;

            Modelo.UserCreacion = "Admin";
  


            if (Modo == "Agregando")
            {
                if (new clientesController().CrearCliente(Modelo) == true)
                {
                    MessageBox.Show("Registro creado exitosamente");
                  
                }
            }
            else
            {
                if (new clientesController().ActualizarCliente(Modelo) == true)
                {
                    MessageBox.Show("Registro Actualizado Exitosamente");
                   

                }
            }
        }


        private void FRMClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblModo_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
