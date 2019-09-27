using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumar_Sobrecarga
{
    class Operaciones
    {
        public void Obtener_datos()
        {
            Datos o = new Datos();
            double var1;
            double var2;
            Console.WriteLine("Bienvenido!");
            Console.WriteLine("Ingrese un dato porfaviurs!: ");
            double var5;
            var5 = Convert.ToDouble(Console.ReadLine());
            double res1 = o.Sumar(var5);
            Console.WriteLine(res1);
            Console.WriteLine("Ingrese dos datos porfaviurs!: ");
            var1 = Convert.ToDouble(Console.ReadLine());
            var2 = Convert.ToDouble(Console.ReadLine());
            double res = o.Sumar(var1, var2);
            Console.WriteLine(res);
            Console.WriteLine("Ingrese tres datos porfaviurs!: ");
            double var3;
            double var4;
            double var6;
            var3 = Convert.ToDouble(Console.ReadLine());
            var4 = Convert.ToDouble(Console.ReadLine());
            var6 = Convert.ToDouble(Console.ReadLine());
            double res2 = (o.Sumar(var3, var4, var6));
            Console.WriteLine(res2);
        }
    }
}
