using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumar_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones p = new Operaciones();
            Datos o = new Datos();
            p.Obtener_datos();
            Console.ReadKey();
        }
    }
}
