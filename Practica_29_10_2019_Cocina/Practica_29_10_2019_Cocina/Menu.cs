using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_29_10_2019_Cocina
{
    public class Menu : Platillo, Imenu
    {
        List<Platillo> platillos = new List<Platillo>();
        public void Welcome()
        {
            int seguir = 1;

            Console.WriteLine("Bienvenido a la cocina!, Primero agreguemos platillos al menu");
            Create_menu();
            Console.Write("Excelente!, ");
            while (seguir == 1)
            {

            
            Console.Write("Que desea realizar ahora?\n(1)Agregar platillo\n(2)Listar los platillos\n: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Create_menu();
                    break;
                case "2":
                    List_menu();
                    break;
                default:
                    break;

            }
            Console.Write("Desea reaizar otra accion?, Si(1), No(2): ");
                seguir = Convert.ToInt32(Console.ReadLine());
            }
    }
        public void Create_menu()
        {

            int add = 1;
            while (add == 1)
            {
                Platillo p = new Platillo();
                Console.Write("Ingrese el ID del platillo: ");
                p.ID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el Nombre del Platillo: ");
                p.Name = Console.ReadLine();
                Console.Write("Ingrese la descripcion del platillo: ");
                p.Description = Console.ReadLine();
                Console.Write("Ingrese el precio del platillo: ");
                p.Price = Convert.ToDouble(Console.ReadLine());
                platillos.Add(p);

                Console.Write("Desea agregar otro platillo?, Si(1), No(2): ");
                add = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }

        public void Details()
        {
            Console.Write("Ingrese el ID del platillo que desea observar: ");
            int IDopcion = Convert.ToInt32(Console.ReadLine());
            foreach(var opcion in platillos)
            {
                if (opcion.ID == IDopcion)
                {
                    Console.WriteLine("ID: {0}",opcion.ID);
                    Console.WriteLine("Nombre: {0}", opcion.Name);
                    Console.WriteLine("Descripcion: {0}", opcion.Description);
                    Console.WriteLine("Precio: {0}", opcion.Price);
                }
            }

        }

        public void List_menu()
        {
            
            foreach(var cantidad in platillos)
            {

                Console.WriteLine("ID: {0}",cantidad.ID);
                Console.WriteLine("Nombre: {0}",cantidad.Name);
            }
            Console.Write("Desea ver los detalles de un platillo?, Si(1), No(2)");
            switch (Console.ReadLine())
            {
                case "1":
                    Details();
                    break;
                case "2":
                    break;
            }

        }
    }
}
