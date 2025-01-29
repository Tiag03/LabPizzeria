using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSistemaPizzeria.Views
{
    public partial class FRMLogin : Form
    {
        public FRMLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnHuella_Click(object sender, EventArgs e)
        {

        }
        void IniciarSesion()
        {
            // Captura los valores ingresados en los TextBox
            string idUsuario = txtuser.Text.Trim();
            string password = txtpass.Text.Trim();

            // Validación de campos vacíos
            if (string.IsNullOrEmpty(idUsuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtén la cadena de conexión desde App.config
            string connectionString = ConfigurationManager.ConnectionStrings["SisPizzeria"].ConnectionString;

            // Consulta SQL
            string query = "SELECT COUNT(*) FROM Usuarios WHERE IdUsuario = @IdUsuario AND password = @Password";

            try
            {
                // Establece la conexión con la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Prepara el comando SQL con parámetros
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        command.Parameters.AddWithValue("@Password", password);

                        // Ejecuta la consulta
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        // Verifica si el usuario existe
                        if (count > 0)
                        {
                            MessageBox.Show("Bienvenido al sistema.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Redirige al formulario principal
                            FRMMenu Menu = new FRMMenu(); // Reemplaza con el formulario principal correcto
                            Menu.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }
    }
}
