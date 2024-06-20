using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public double Calificacion { get; set; }

        public Estudiante( string nombre, double calificacion) 
        {
            Nombre = nombre;
            Calificacion = calificacion;
        }     

    }
}