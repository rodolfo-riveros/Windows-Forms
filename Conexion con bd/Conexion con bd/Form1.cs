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

namespace Conexion_con_bd
{
    public partial class Form1 : Form
    {
        // Configuración de la conexión a la base de datos
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1; port=3306; user id=root; password=; database=login; sslMode=none");

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Intentando conectar a la base de datos...");
                conn.Open();
                MessageBox.Show("Conexión a la base de datos exitosa.");
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
            }
        }
    }
}
