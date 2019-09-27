using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumar_Sobrecarga
{
    class Datos
    {
        public double Sumar(double x, double y, double z)
        {
            double var = 0;
            var = x + y + z;
            return var;
        }
        public double Sumar(double x, double y)
        {
            double var = 0;
            var = x + y;
            return var;
        }
        public double Sumar(double x)
        {
            double var = 0;
            var = x + 8;
            return var;
        }
    }
}
