using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangulo
{
    public class Rectangulo
    {
        public double Base {  get; set; }
        public double Altura { get; set; }

        public Rectangulo(double baseRectangulo, double alturaRectangulo) 
        {
            Base = baseRectangulo;
            Altura = alturaRectangulo;
        }

        public double CalcularArea()
        {
            return Base * Altura; 
        }
    }
}
