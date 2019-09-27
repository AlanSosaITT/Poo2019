using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operaciones
    {
        public double Sumar(double nume1,double nume2)
        {
            double res = nume1+nume2;
            return res;
        }
        public double Sumar(double nume1,double nume2, double nume3)
        {
            double res = nume1+nume2+nume3;
            return res;
        }
        public double Restar(double nume1,double nume2)
        {
            double res = nume1-nume2;
            return res;
        }
        public double Restar(double nume1,double nume2, double nume3)
        {
            double res = nume1-nume2-nume3;
            return res;
        }
        
        public double Multiplicar(double nume1,double nume2)
        {
            double res = nume1*nume2;
            return res;
        }
        public double Multiplicar(double nume1,double nume2, double nume3)
        {
            double res = nume1*nume2*nume3;
            return res;
        }
        public double Dividir(double nume1,double nume2)
        {
            double res = nume1/nume2;
            return res;
        }
        public double Dividir(double nume1,double nume2, double nume3)
        {
            double res = nume1/nume2/nume3;
            return res;
        }
        public void Bienvebido()
        {
            Console.WriteLine("Bienvenido a la calculadora!, que operacion desea realizar?, Sumar(1), Restar(2), Multiplicar(3), Dividir(4): ");
            int opc = 0;
            opc = Convert.ToInt32(Console.ReadLine());
            if (opc == 1)
            {
                Console.WriteLine("Cuantos numero desea sumar(Minimo 2, Maximo 3)?: ");
                int opc1 = 0;
                double nume1 = 0;
                double nume2 = 0;
                double nume3 = 0;
                opc1 = Convert.ToInt32(Console.ReadLine());
                if (opc1 == 2)
                {
                    Console.WriteLine("Ingrese el valor del numero 1: ");
                    nume1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del numero 2: ");
                    nume2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Sumar(nume1, nume2));
                }
                else if (opc1 == 3)

                {
                    Console.WriteLine("Ingrese el valor del numero 1: ");
                    nume1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del numero 2: ");
                    nume2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del numero 3: ");
                    nume3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Sumar(nume1, nume2, nume3));
                }
                
            }
            else if (opc == 2)
            {
                Console.WriteLine("Cuantos numero desea restar(Minimo 2, Maximo 3)?: ");
                int opc1 = 0;
                double nume1 = 0;
                double nume2 = 0;
                double nume3 = 0;
                opc1 = Convert.ToInt32(Console.ReadLine());
                if (opc1 == 2)
                {
                    Console.WriteLine("Ingrese el valor del numero 1: ");
                    nume1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del numero 2: ");
                    nume2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Restar(nume1, nume2));
                }
                else if (opc1 == 3)

                {
                    Console.WriteLine("Ingrese el valor del numero 1: ");
                    nume1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del numero 2: ");
                    nume2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del numero 3: ");
                    nume3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Restar(nume1, nume2, nume3));
                }
            }
            else if (opc == 3)
            {
                Console.WriteLine("Cuantos numero desea Multiplicar(Minimo 2, Maximo 3)?: ");
                int opc1 = 0;
                double nume1 = 0;
                double nume2 = 0;
                double nume3 = 0;
                opc1 = Convert.ToInt32(Console.ReadLine());
                if (opc1 == 2)
                {
                    Console.WriteLine("Ingrese el valor del numero 1: ");
                    nume1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del numero 2: ");
                    nume2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Multiplicar(nume1, nume2));
                    
                }
                else if (opc1 == 3)

                {
                    Console.WriteLine("Ingrese el valor del numero 1: ");
                    nume1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del numero 2: ");
                    nume2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del numero 3: ");
                    nume3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Multiplicar(nume1, nume2,nume3));
                }
            }
            else if (opc == 4)
            {
                Console.WriteLine("Cuantos numero desea Dividir(Maximo 3)?: ");
                int opc1 = 0;
                double nume1 = 0;
                double nume2 = 0;
                double nume3 = 0;
                opc1 = Convert.ToInt32(Console.ReadLine());
                if (opc1 == 2)
                {
                    Console.WriteLine("Ingrese el valor del numero 1: ");
                    nume1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del numero 2: ");
                    nume2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Dividir(nume1, nume2));
                }
                else if (opc1 == 3)

                {
                    Console.WriteLine("Ingrese el valor del numero 1: ");
                    nume1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del numero 2: ");
                    nume2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del numero 3: ");
                    nume3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Dividir(nume1, nume2, nume3));
                }
            }
        }
    }
}
