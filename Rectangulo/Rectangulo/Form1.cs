using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de base y altura de los TextBox
                double baseRectangulo = double.Parse(TxtBase.Text);
                double alturaRectangulo = double.Parse(TxtAltura.Text);

                // Crear una instancia de la clase Rectangulo
                Rectangulo rectangulo = new Rectangulo(baseRectangulo, alturaRectangulo);

                // Calcular el área
                double area = rectangulo.CalcularArea();

                // Mostrar el resultado en el Label
                LblRectangulo.Text = "El área del rectángulo es: " + area.ToString();

                // Borrar los TxtBox una vez calculado
                TxtBase.Clear();
                TxtAltura.Clear();
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }
    }
}
