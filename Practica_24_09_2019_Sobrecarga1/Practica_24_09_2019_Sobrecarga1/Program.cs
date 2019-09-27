using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_24_09_2019_Sobrecarga1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciasion de la clase Datos, que contiene el Metodo
            Datos o = new Datos();
            //Llamada del metodo
            o.Obtener_datos();
            Console.ReadKey();
        }
    }
}
