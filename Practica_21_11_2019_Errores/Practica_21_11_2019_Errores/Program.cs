using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_21_11_2019_Errores
{
    class Program
    {
        static void Main(string[] args)
        {
            var estudiante = new List<Estudiante>();
            var agregar = true;

            while (agregar==true)
            {
                int ciclo = 1;
                while (ciclo == 1)
                {


                    var e = new Estudiante();
                    try
                    {
                        int opc = 1;
                        Console.WriteLine("Ingrese su Matricula: ");
                        bool result;
                        int matricula = 0;
                        while (opc == 1)
                        {
                            result = int.TryParse(Console.ReadLine(), result: out matricula);
                            if (result == false)
                            {
                                Console.Write("Igrese un numero porfavor: ");
                            }
                            else if (result == true)
                            {
                                e.ID = matricula;
                                opc = 2;
                            }
                        }
                        Console.WriteLine("Matricula: " + e.ID);
                        Console.WriteLine("Ingrese su Nombre: ");
                        e.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese su Carrera: ");
                        e.Carrera = Console.ReadLine();
                        Console.WriteLine("Ingrese su Semestre: ");
                        e.Semestre = Convert.ToInt32(Console.ReadLine());
                        estudiante.Add(e);
                        ciclo = 2;
                    }
                    catch
                    {
                        Console.WriteLine("Error agregando el usuario intente nuevamente xdxd");
                    }
                }
                Console.Write("Desea agregar otro usuario?, Si(1), No(2): ");
                if (Console.ReadLine() == "2")
                {
                    agregar = false;
                }
            }
            Console.WriteLine("Hasta la proxima");
            Console.ReadLine();
        }
    }
}
