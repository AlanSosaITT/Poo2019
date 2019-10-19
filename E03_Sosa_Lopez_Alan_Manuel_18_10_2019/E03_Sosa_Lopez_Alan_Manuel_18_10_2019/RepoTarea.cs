using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Sosa_Lopez_Alan_Manuel_18_10_2019
{
    public class RepoTarea
    {
        public RepoTarea()
        {
            
        }
        //Instanciamos la clase dato para utilizar sus contenidos
        Dato dato = new Dato();
        
        //creamos el metodo de bienvenida, mismo donde llamamos a los metodos
        public void Bienvenido()
        {
            Console.WriteLine("Bienvendio al administrador de Que hacer!, Agregue un usuario porfavor!");
            Agregar_usuario();
            Menu();
        }
        //creacion de metodo
        public void Observar_usuario()
        {
            int opcc = 1;
            while (opcc == 1)
            {
                //capturamos el ID de el usuario a buscar
                Console.Write("Que usuario desea ver?, Ingrese su ID: ");
                int opcU;
                opcU = Convert.ToInt32(Console.ReadLine());
                Usuario p = new Usuario();
                //uso del foreach para comparar cada elemento con su ID
                foreach (var usuarios in dato.usuarios)
                {
                    if (opcU == usuarios.ID)
                    {
                        //Asignamos un objeto nuevo al anterior asignado
                        p = usuarios;
                        break;
                    }
                }
                //imprimimos los datos
                Console.WriteLine("Nombre: {0}", p.Nombre);
                Console.WriteLine("ID: {0}", p.ID);              
                Console.WriteLine("Desea ver a otro usuario?, Si(1), No(2)");
                opcc = Convert.ToInt32(Console.ReadLine());
                if (opcc == 1)
                {
                    Console.Clear();
                }
            }
        }
        public void Agregar_usuario()
        {
            int opc = 1;
            while (opc == 1)
            {
                //Pedimos datos para hacer el metodo, mismo que nos pide parametros para realizarse
                Console.Write("ID: ");
                int ID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nombre: ");
                string Nombre = Console.ReadLine();
                dato.Agregar_usuario(ID, Nombre);
                Console.Write("Desea agregar otro usuario?\nSi(1)\nNo(2)\n: ");
                opc = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
        public void Agregar_tarea()
        {
            int opcb = 1;
            while (opcb == 1)
            {


                Console.Write("A que usuario desea agregar una tarea?, Ingrese su ID: ");
                int opcU;
                opcU = Convert.ToInt32(Console.ReadLine());
                Usuario p = new Usuario();
                foreach (var usuarios in dato.usuarios)
                {
                    if (opcU == usuarios.ID)
                    {
                        p = usuarios;
                        break;
                    }
                }
                int opca = 1;
                while (opca == 1)
                {
                    //Pedimos los datos para llenar en nuestra lista de tareas
                    Console.WriteLine("Ingrese los detalles porfavor!");
                    Console.Write("ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Descripcion: ");
                    string descripcion = Console.ReadLine();
                    Console.Write("Horario: ");
                    string horario = Console.ReadLine();
                    Console.Write("Vencimiento(Dia / Mes / Año): ");
                    DateTime vencimiento = Convert.ToDateTime(Console.ReadLine());
                    dato.Agregar_tarea(p, id, nombre, descripcion, horario, vencimiento);
                    Console.Write("Desea agregar otra tarea a este usuario?, Si(1), No(2): ");
                    opca = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Desea agregar una tarea a algun otro usuario?, Si(1), No(2): ");
                opcb = Convert.ToInt32(Console.ReadLine());
                if (opcb == 1)
                {
                    Console.Clear();
                }
            }

        }
        public void Ver_tareas()
        {
            int opcd = 1;
            while (opcd == 1)
            {
                //Pedimos un numero de id para comparar y mostrar
                Console.Write("Que usuario desea ver?, Ingrese su ID: ");
                int opcU;
                opcU = Convert.ToInt32(Console.ReadLine());
                Usuario p = new Usuario();
                foreach (var usuarios in dato.usuarios)
                {
                    if (opcU == usuarios.ID)
                    {
                        p = usuarios;
                        break;
                    }
                }
                Console.WriteLine("Nombre: {0}", p.Nombre);
                Console.WriteLine("ID: {0}", p.ID);
                foreach (var tarea in p.tareas)
                {
                    Console.WriteLine("Nombre {0}, ID {1}",tarea.Nombre,tarea.ID);
                }
                Console.Write("Que tarea desea ver?, Ingrese su ID: ");
                int opce=Convert.ToInt32(Console.ReadLine());
                foreach (var tarea in p.tareas)
                {
                    if (opce == tarea.ID)
                    {
                        Console.WriteLine(tarea.Nombre);
                        Console.WriteLine(tarea.Descripcion);
                        Console.WriteLine(tarea.Horario);
                        Console.WriteLine(tarea.Vencimiento);
                        Console.WriteLine(tarea.Estatus);
                    }
                }
                Console.WriteLine("Desea ver a otro usuario?, Si(1), No(2)");
                opcd = Convert.ToInt32(Console.ReadLine());
                if (opcd == 1)
                {
                    Console.Clear();
                }
            }
        }
        //Creacion de metodo para cambiar el estatus de cada tarea
        public void Cambiar_estatus()
        {
            int opcd = 1;
            while (opcd == 1)
            {
                Console.Write("Que usuario desea modificar?, Ingrese su ID: ");
                int opcU;
                opcU = Convert.ToInt32(Console.ReadLine());
                Usuario p = new Usuario();
                foreach (var usuarios in dato.usuarios)
                {
                    if (opcU == usuarios.ID)
                    {
                        p = usuarios;
                        break;
                    }
                }
                Console.WriteLine("Nombre: {0}", p.Nombre);
                Console.WriteLine("ID: {0}", p.ID);
                foreach (var tarea in p.tareas)
                {
                    Console.WriteLine("Nombre {0}, ID {1}, Estatus {2}", tarea.Nombre, tarea.ID,tarea.Estatus);
                }
                Console.Write("Que tarea desea cambiar su estatus?, Ingrese su ID: ");
                int opce = Convert.ToInt32(Console.ReadLine());
                foreach (var tarea in p.tareas)
                {
                    if (opce == tarea.ID)
                    {
                        Console.Write("Ingrese su nuevo estatus: ");
                        tarea.Estatus = Console.ReadLine();
                    }
                }
                Console.WriteLine("Desea modificar a otro usuario?, Si(1), No(2)");
                opcd = Convert.ToInt32(Console.ReadLine());
                if (opcd == 1)
                {
                    Console.Clear();
                }
            }
        }
        //Metodo que da coneccion a todos los metodos, creando asi un menu.
        public void Menu()
        {
            int opcf = 1;
            while (opcf == 1)
            {
                Console.Write("Que desea realizar?\nAgregar usuario(1)\nRevisar usuario(2)\nAgregar tarea(3)\nVer tareas(4)\nCambiar estatus(5)\n: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Agregar_usuario();
                        Console.Write("Desea realizar algun operacion? Si(1), No(2): ");
                        opcf = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "2":
                        Observar_usuario();
                        Console.Write("Desea realizar algun operacion? Si(1), No(2): ");
                        opcf = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "3":
                        Agregar_tarea();
                        Console.Write("Desea realizar algun operacion? Si(1), No(2): ");
                        opcf = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "4":
                        Ver_tareas();
                        Console.Write("Desea realizar algun operacion? Si(1), No(2): ");
                        opcf = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "5":
                        Cambiar_estatus();
                        Console.Write("Desea realizar algun operacion? Si(1), No(2): ");
                        opcf = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
