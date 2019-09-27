using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_25_09_19_2
{
    class Operaciones
    {
        public void Bienvenido()
        {
            Data d = new Data();
            Console.WriteLine("Bienvenido a mi programa!, que desea calculatr?, Cuadrado(1), Rectangulo(2), Triangulo (3)");
            int opc = 0;
            opc = Convert.ToInt16(Console.ReadLine());
            if (opc == 1)
            {
                Console.WriteLine("Ingrese el lado del cuadrado: ");
                double lado = 0;
                double total = 0;
                lado = Convert.ToDouble(Console.ReadLine());
                total=(d.Area(lado));
                Console.WriteLine("Area: {0}",total);
            }
            if (opc == 2)
            {
                Console.WriteLine("Ingrese el lado 1 del Rectangulo: ");
                double lado = 0;
                lado = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el lado 2 del Rectangulo: ");
                double lado2 = 0;
                lado2 = Convert.ToDouble(Console.ReadLine());
                double total = 0;           
                total = (d.Area(lado, lado2));
                Console.WriteLine("Area: {0}", total);
            }
            if (opc == 3)
            {
                Console.WriteLine("Ingrese la base del Triangulo: ");
                double lado = 0;
                lado = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del Triangulo: ");
                double lado2 = 0;
                double division = 2;
                lado2 = Convert.ToDouble(Console.ReadLine());
                double total = 0;
                total = (d.Area(lado, lado2,division));
                Console.WriteLine("Area: {0}", total);
            }
        }

    }
}
