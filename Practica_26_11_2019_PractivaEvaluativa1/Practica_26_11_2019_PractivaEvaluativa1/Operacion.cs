using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practica_26_11_2019_PractivaEvaluativa1
{
    public class Operacion
    {
        int id = 0;
        List<Persona> personas = new List<Persona>();
        public void ObtenerPersona()
        {
            int opc = 1;
            while (opc == 1)
            {
                try
                {
                    Persona p = new Persona();
                    id = id + 1;
                    p.ID = id;
                    Console.WriteLine("ID: " + id);
                    Console.Write("Ingrese su Nombre: ");
                    p.Nombre = Console.ReadLine();
                    Console.Write("Ingrese su Profesion: ");
                    p.Profesion = Console.ReadLine();
                    Console.Write("Ingrese su Edad: ");
                    p.Edad = Convert.ToInt32(Console.ReadLine());
                    personas.Add(p);
                    List<string> lineas = ObtenerLineas(p);
                    imprimir(p, lineas);
                    opc = 2;
                }
                catch
                {
                    Console.WriteLine("Error, Formato incorrecto, ingrese los datos de nuevo porfavor");
                }
            }
        }

        public List<string> ObtenerLineas(Persona p)
        {
            List<string> lineas = new List<string>();
            lineas.Add("ID: "+p.ID);
            lineas.Add("Nombre: " + p.Nombre);
            lineas.Add("Profesion: " + p.Profesion);
            lineas.Add("Edad: " + p.Edad);          
            return lineas;
        }
        public void Menu()
        {
            int opcciclo = 1;
            
            Console.WriteLine("Bienvenido!, Ingrese un Alumno porfavor");
            ObtenerPersona();
            while (opcciclo == 1)
            {
                Console.Write("Desea agregar otro usuario?, Si(1), No(2): ");
                switch (Console.ReadLine())
                {
                    case "1":
                        ObtenerPersona();
                        break;
                    case "2":
                        opcciclo = 2;
                        break;
                }
            }

            Console.Write("Ingrese el ID del alumno que desea buscar: ");
            int id = Convert.ToInt32(Console.ReadLine());
            BuscarPersona(id);
        }
        public void BuscarPersona(int id)
        {
            Persona per = new Persona();
            foreach(var elegido in personas)
            {
                if (id == elegido.ID)
                {
                    per = elegido;
                    break;
                }
            }
            var lineas=ObtenerLineas(per);
            Console.WriteLine("Su formato se a impreso en Datos.txt");
            imprimir(per, lineas);
        }
        public void imprimir(Persona p,List<string> lineas)
        {
            File.WriteAllLines("Datos.txt", lineas);
            
        }
    }
}
