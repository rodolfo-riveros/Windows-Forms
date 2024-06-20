using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perro
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de nombre y raza de los TextBox
                string nombrePerro = txtName.Text;
                string razaPerro = txtRaza.Text;

                // Verificar si los campos no están vacíos
                if (string.IsNullOrWhiteSpace(nombrePerro) || string.IsNullOrWhiteSpace(razaPerro))
                {
                    MessageBox.Show("Por favor, ingrese valores válidos para nombre y raza.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear una instancia de la clase Perro
                Perro perro = new Perro(nombrePerro, razaPerro);

                // Obtener los detalles del perro
                string detallePerro = perro.DetallePerro();

                // Agregar los detalles del perro al DataGridView
                tablaPerro.Rows.Add(perro.Nombre, perro.Raza);

                // Borrar los TextBox una vez agregado
                txtName.Clear();
                txtRaza.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
