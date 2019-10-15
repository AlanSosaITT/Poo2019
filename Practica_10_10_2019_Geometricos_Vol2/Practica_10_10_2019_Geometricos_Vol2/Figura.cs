using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_10_10_2019_Geometricos_Vol2
{
    public class Figura
    {
        public int Lado { get; set; }
        public double CalcularArea(Cuadrado c)
        {
            double res = 0;
            res = c.Lado*c.Lado;
            return res;
        }
        public double CalcularArea(Rectangulo r,string msg)
        {
            double res = 0;
            res = r.Lado*r.Altura;
            return res;
        }
    }
}
