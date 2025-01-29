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
    public partial class FRMProducto : Form
    {
        string Modo = "";
        ProductosModel Modelo;
        
        public FRMProducto()
        {
            InitializeComponent();
            Modo = "Agregando";
            lblModo.Text = Modo;
        }
        public FRMProducto(string ProductoID)
        {
            InitializeComponent();
            Modo = "Editando";
            lblModo.Text = Modo;

            foreach (DataRow Fila in ProductosModel.GetProducto.Rows)
            {
                if (Fila["ProductoID"].ToString() == ProductoID)
                {
                    txtIdProducto.Text = Fila["ProductoID"].ToString();
                    txtNombre.Text = Fila["Nombre"].ToString();
                    txtDescripcion.Text = Fila["Descripcion"].ToString();
                    txtPrecio.Text = Fila["Precio"].ToString();
                    break;
                }
            }


        }
        void Salvar()
        {
            Modelo = new ProductosModel();
            Modelo.ProductoID = txtIdProducto.Text;
            Modelo.Nombre = txtNombre.Text;
            Modelo.Descripcion = txtDescripcion.Text;
            Modelo.Precio = decimal.Parse(txtPrecio.Text);
            Modelo.Activo = cbActivo.Checked;

            Modelo.UserCreacion = "Admin";



            if (Modo == "Agregando")
            {
                if (new ProductosController().CrearProducto(Modelo) == true)
                {
                    MessageBox.Show("Registro creado exitosamente");

                }
            }
            else
            {
                if (new ProductosController().CrearProducto(Modelo) == true)
                {
                    MessageBox.Show("Registro Actualizado Exitosamente");


                }
            }
        }
        private void FRMProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
