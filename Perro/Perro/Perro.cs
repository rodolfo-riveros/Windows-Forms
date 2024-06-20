using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perro
{
    public class Perro
    {
        public string Nombre { get; set; }
        public string Raza { get; set; }


        public Perro(string nombrePerro, string razaPerro)
        {
            Nombre = nombrePerro;
            Raza = razaPerro;
        }

        public string DetallePerro()
        {
            return $"El perro es: {Nombre}, la raza es: {Raza}";
        }
    }
}
