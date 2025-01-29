using LabSistemaPizzeria.Controllers;
using LabSistemaPizzeria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSistemaPizzeria.Views
{
    public partial class FRMListClientes : Form
    {
        public FRMListClientes()
        {
            InitializeComponent();
        }
        public void CargarClientes()
        {
            new clientesController().ListarCliente();
            dgvDatos.DataSource = ClientesModel.GetClientes;
            dgvDatos.Columns["IdCliente"].Width = 150;
            dgvDatos.Columns["Nombre"].Width = 300;
            dgvDatos.Columns["Apellido"].Width = 200;
            dgvDatos.Columns["Correo"].Width = 200;
        }

            private void btnNuevo_Click(object sender, EventArgs e)
        {
            FRMClientes frmC = new FRMClientes();
            frmC.ShowDialog();
        }

        private void FRMListClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }
    }
}
