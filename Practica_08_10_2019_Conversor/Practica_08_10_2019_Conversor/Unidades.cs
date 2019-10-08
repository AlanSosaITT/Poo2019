using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_08_10_2019_Conversor
{
    class Unidades
    {
        //Declaracion y encapsulado
        public double Metro { get; set; }
        //Metodos para conversion de cada unidad 
        public double Conversion_M_P(double x, out double total)
        {
            total = (x * 100)/2.54;
            return total;
        }
        public double Conversion_M_C(double x, out double total)
        {
            total = x *100;
            return total;
        }
        public double Pulgada { get; set; }
        public double Conversion_P_M(double x, out double total)
        {
            total = x*.0254 ;
            return total;
        }
        public double Conversion_P_C(double x, out double total)
        {
            total = x *2.54;
            return total;
        }
        public double centimetro { get; set; }
        public double Conversion_C_M(double x, out double total)
        {
            total = x /100;
            return total;
        }
        public double Conversion_C_P(double x, out double total)
        {
            total = x / 2.54;
            return total;
        }
    }
}
