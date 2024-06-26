using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Registro_persona
{
    public partial class Form1 : Form
    {
        // Configuración de la conexión a la base de datos
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1; port=3306; user id=root; password=; database=persona; sslMode=none");

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadData();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia de la clase Persona y asigna valores desde los TextBoxes
            Persona persona = new Persona
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaHora = DateTime.Now // Captura la fecha y hora actual
            };

            AgregarPersona(persona); // Agrega la persona a la base de datos
            LoadData(); // Recarga los datos para reflejar la nueva inserción
        }

        private void AgregarPersona(Persona persona)
        {
            try
            {
                conn.Open(); // Abre la conexión a la base de datos
                string query = "INSERT INTO personas (Nombre, Apellido, FechaHora) VALUES (@Nombre, @Apellido, @FechaHora)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                // Asigna los valores de los parámetros de la consulta
                cmd.Parameters.AddWithValue("@Nombre", persona.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", persona.Apellido);
                cmd.Parameters.AddWithValue("@FechaHora", persona.FechaHora);
                cmd.ExecuteNonQuery(); // Ejecuta la consulta
                MessageBox.Show("Datos agregados exitosamente.");

                // Limpia los TextBoxes
                txtNombre.Clear();
                txtApellido.Clear();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al agregar datos: " + ex.Message);
            }
            finally
            {
                conn.Close(); // Cierra la conexión a la base de datos
            }
        }

        private void LoadData()
        {
            try
            {
                conn.Open(); // Abre la conexión a la base de datos
                string query = "SELECT * FROM personas";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt); // Llena el DataTable con los datos de la consulta
                tablaPersona.DataSource = dt; // Asigna el DataTable al DataGridView
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
            finally
            {
                conn.Close(); // Cierra la conexión a la base de datos
            }
        }
    }
}
