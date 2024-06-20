using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiante
{
    public partial class Form1 : Form
    {
        private List<Estudiante> estudiantes;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            estudiantes = new List<Estudiante>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de nombre y calificación de los TextBox
                string nombreEstudiante = txtEstudiante.Text;
                double calificacionEstudiante;

                if (string.IsNullOrWhiteSpace(nombreEstudiante) || !double.TryParse(txtCalificacion.Text, out calificacionEstudiante))
                {
                    MessageBox.Show("Por favor, ingrese valores válidos para nombre y calificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear una instancia de la clase Estudiante
                Estudiante estudiante = new Estudiante(nombreEstudiante, calificacionEstudiante);

                // Agregar el estudiante a la lista y al DataGridView
                estudiantes.Add(estudiante);
                tablaEstudiante.Rows.Add(estudiante.Nombre, estudiante.Calificacion);

                // Calcular y mostrar el promedio de calificaciones
                MostrarPromedio();

                // Borrar los TextBox una vez agregado
                txtEstudiante.Clear();
                txtCalificacion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarPromedio()
        {
            if (estudiantes.Count > 0)
            {
                double promedio = 0;
                foreach (Estudiante estudiante in estudiantes)
                {
                    promedio += estudiante.Calificacion;
                }
                promedio /= estudiantes.Count;
                lblPromedio.Text = $"Promedio de Calificaciones: {promedio:F2}";
            }
        }
    }
}
