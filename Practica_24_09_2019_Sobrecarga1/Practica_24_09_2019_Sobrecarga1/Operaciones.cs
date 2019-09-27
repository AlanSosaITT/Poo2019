using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_24_09_2019_Sobrecarga1
{
    class Operaciones
    {
        //Declaracion del metodo por sobrecarga, cada uno con sus respectivas variables.
        public double Multiplicar(double x, double y, double z)
        {
            double var = 0;
            var = x * y * z;
            return var;
        }
        public double Multiplicar(double x, double y)
        {
            double var = 0;
            var = x * y;
            return var;
        }
        public double Multiplicar(double x)
        {
            double var = 0;
            var = x * 8;
            return var;
        }
    }
}
