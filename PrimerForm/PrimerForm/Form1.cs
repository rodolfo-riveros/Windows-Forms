using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Configurar la posición inicial del formulario
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica si el texto del TextBox no está vacío o compuesto solo por espacios en blanco
            if (!string.IsNullOrWhiteSpace(TxtName.Text) && !ListName.Items.Contains(TxtName.Text))
            {
                // Si el texto no está en el ListBox, lo añade
                ListName.Items.Add(TxtName.Text);

                // Limpia el TextBox después de intentar agregar el nombre
                TxtName.Clear();
            }
            else
            {
                MessageBox.Show("El nombre está vacío o ya existe en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
