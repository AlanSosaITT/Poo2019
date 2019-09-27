using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cambio
{
    class Operaciones
    {
        public void Bienvenido()
        {


            Data d = new Data();
            int total = 0;
            int pesos = 0;
            int centavos = 0;
            d.Convertir(total, out pesos, out centavos);
            Console.WriteLine("Pesos: {0}",pesos);
            Console.WriteLine("Centavos: {0}",centavos);
        }
    }
}
