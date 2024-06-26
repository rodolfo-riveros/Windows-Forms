using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{
    public partial class Form1 : Form
    {
        // Configuración de la conexión a la base de datos
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;port=3306;user id=root;password=;database=login;sslMode=none");

        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*'; // Establece el carácter de máscara para la contraseña
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            // Verificación de que los campos no estén vacíos
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.");
                return;
            }

            // Intentar conexión y registro de usuario
            try
            {
                MessageBox.Show("Intentando conectar a la base de datos...");
                conn.Open();
                MessageBox.Show("Conexión a la base de datos exitosa.");

                string query = "INSERT INTO usuarios (User, Password) VALUES (@usuario, @contrasena)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", username);
                cmd.Parameters.AddWithValue("@contrasena", password);

                int result = cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado exitosamente. Filas afectadas: " + result);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    MessageBox.Show("Conexión cerrada.");
                }
                else
                {
                    MessageBox.Show("La conexión no estaba abierta.");
                }
            }
        }
    }
}

