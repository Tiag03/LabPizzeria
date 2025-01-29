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
    public partial class FRMListProducto : Form
    {
        public FRMListProducto()
        {
            InitializeComponent();
        }

        void CargarProductos()
        {
            new ProductosController().ListarProductos();
            dgvDatos.DataSource = ProductosModel.GetProducto;
          //  dgvDatos.Columns["ProductoID"].Width = 150;
            dgvDatos.Columns["Nombre"].Width = 200;
            dgvDatos.Columns["Descripcion"].Width = 300;
            dgvDatos.Columns["Precio"].Width = 100;
        }

    private void FRMListProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FRMProducto frmProducto = new FRMProducto();
            frmProducto.ShowDialog();
        }
    }
}
