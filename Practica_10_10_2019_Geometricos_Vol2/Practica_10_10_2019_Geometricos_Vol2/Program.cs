using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_10_10_2019_Geometricos_Vol2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado c = new Cuadrado();
            Rectangulo r = new Rectangulo();         
            r.Altura = 25;
            r.Lado = 10;
            c.Lado = 35;
            var cArea=c.CalcularArea(c);
            var rArea = r.CalcularArea(r,"Osi Osi");
            Console.WriteLine("Area del cuadrado: {0}",cArea);
            Console.WriteLine("Area del rectangulo: {0}",rArea);
            Console.ReadKey();
        }
    }
}
