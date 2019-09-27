using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_24_09_2019_Sobrecarga1
{
    class Datos
    {
        public void Obtener_datos()
        {
            //Instanciacion de la clase Operaciones,para mandar a llamar a los metodos.
            Operaciones o = new Operaciones();
            //Declaracion de variables que nos serviran para almacenar los datos
            double var1;
            double var2;
            Console.WriteLine("Bienvenido!");
            Console.WriteLine("Ingrese un dato porfaviurs!: ");
            double var5;
            var5 = Convert.ToDouble(Console.ReadLine());
            //Asiganmos una variable que guardara el resultado de la operacion mandada a llamar.
            double res1 = o.Multiplicar(var5);
            Console.WriteLine(res1);
            Console.WriteLine("Ingrese dos datos porfaviurs!: ");
            var1 = Convert.ToDouble(Console.ReadLine());
            var2 = Convert.ToDouble(Console.ReadLine());
            double res = o.Multiplicar(var1, var2);
            Console.WriteLine(res);
            Console.WriteLine("Ingrese tres datos porfaviurs!: ");
            double var3;
            double var4;
            double var6;
            var3 = Convert.ToDouble(Console.ReadLine());
            var4 = Convert.ToDouble(Console.ReadLine());
            var6 = Convert.ToDouble(Console.ReadLine());
            double res2 = (o.Multiplicar(var3, var4, var6));
            Console.WriteLine(res2);

        }
    }
}
