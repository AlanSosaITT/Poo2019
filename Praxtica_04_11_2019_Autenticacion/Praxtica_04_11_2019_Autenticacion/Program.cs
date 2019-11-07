using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praxtica_04_11_2019_Autenticacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Register r = new Register();
            Console.WriteLine("Bienvenido al Login!");
            int ciclo = 1;
            while (ciclo == 1)
            {
                Console.Write("Registrarse(1), Ingresar(2): ");
                switch (Console.ReadLine())
                {
                    case "1":
                        User p = new User();
                        Console.Write("Ingrese su nombre: ");
                        p.Name = Console.ReadLine();
                        Console.Write("Ingrese su nombre de usuario: ");
                        p.Username = Console.ReadLine();
                        Console.Write("Ingrese su Contraseña: ");
                        p.Password = Console.ReadLine();
                        string ruta = "Datos.txt";
                        r.Register_user(p, ruta);

                        break;
                    case "2":
                        int opcciclo = 1;
                        while (opcciclo == 1)
                        {


                            Console.Write("Ingrese su nombre de ususario: ");
                            string nameopc = Console.ReadLine();

                            foreach (var xdxd in r.users)
                            {
                                
                                if (nameopc == xdxd.Username)
                                {
                                    int opc = 1;
                                    while (opc == 1)
                                    {
                                        Console.Write("Ingrese su contraseña: ");
                                        if (Console.ReadLine() == xdxd.Password)
                                        {
                                            Console.WriteLine("Bienvenido {0}", xdxd.Name);
                                            Console.ReadKey();
                                            opc = 2;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Incorrecto intente de nuevo");
                                            
                                        }
                                    }

                                    opcciclo = 2;

                                    break;
                                }

                                
                            }
                        }
                        break;
                }
                Console.Write("Desea realizar otra operacion?, Si(1), No(2): ");
                ciclo = Convert.ToInt32(Console.ReadLine());
                
             }Console.ReadKey();
        }
    }
}
