using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cambio
{
    class Data
    {
        public void Convertir(int total, out int pesos, out int centavos)
        {
            Console.WriteLine("Ingrese la cantidad de centavos");
            total = Convert.ToInt32(Console.ReadLine());
            pesos = total / 100;
            centavos = total % 100;
        }
    }
}
