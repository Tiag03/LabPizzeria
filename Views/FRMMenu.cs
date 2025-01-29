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
    public partial class FRMMenu : Form
    {
        public FRMMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            FRMListClientes listClientes = new FRMListClientes();
            listClientes.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FRMUsuarios frmUsuarios = new FRMUsuarios();
            frmUsuarios.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMListProducto frmProducto = new FRMListProducto();
            frmProducto.ShowDialog();
        }
    }
}
