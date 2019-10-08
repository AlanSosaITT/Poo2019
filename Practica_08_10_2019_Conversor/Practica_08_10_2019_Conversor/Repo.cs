using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_08_10_2019_Conversor
{
    class Repo
    {
        public void Bienvenido()
        {
            //declaracion de variables globales a usar
            int opc1 = 0;
            double total = 0;
            //Instansiacion de la clase Unidades (Contenedora de los metodos y datos a usar
            Unidades u = new Unidades();
            int opc = 0;
            int opcf = 1;
            //Ciclo While para volver a usar el programa si asi de desea
            while(opcf==1)
            {
                //Limpiado de consola para mejor vizualicacion despues de reultilizar
                Console.Clear();
                //Pedida de Unidad a convertit
                Console.WriteLine("Bienvenido al conversor de unidades!, Que unidad Desea ingresar?, Metro(1), Pulgada(2), Centimetro(3): ");
                opc = Convert.ToInt32(Console.ReadLine());
            

                //Switch para el caso de unidad que desea convertir
                switch (opc)
                {
                    case 1:

                        Console.Write("Ingrese la cantidad de metros: ");
                        //Asignacion de valor a la Varibale de la clase Unidades
                        u.Metro = Convert.ToDouble(Console.ReadLine());
                        Console.Write("A que unidad desea convertir?, Pulgadas(1), Centimetros(2): ");
                        opc1 = Convert.ToInt32(Console.ReadLine());
                        if (opc1 == 1)
                        {
                            //Uso de metodos De la clase Unidades
                            u.Conversion_M_P(u.Metro, out total);
                            Console.WriteLine("{0} Metros= {1} Pulgadas", u.Metro, total);
                            Console.Write("Desea Convertir otra cantidad?, Si(1), No(2): ");
                            opcf = Convert.ToInt32(Console.ReadLine());
                        }

                        else if (opc1 == 2)
                        {

                            u.Conversion_M_C(u.Metro, out total);
                            Console.WriteLine("{0} Metros= {1} Centimetros", u.Metro, total);
                            Console.Write("Desea Convertir otra cantidad?, Si(1), No(2): ");
                            opcf = Convert.ToInt32(Console.ReadLine());
                        }
                        break;
                    case 2:
                        Console.Write("Ingrese la cantidad de Pulgadas: ");
                        u.Pulgada = Convert.ToDouble(Console.ReadLine());
                        Console.Write("A que unidad desea convertir?, Metros(1), Centimetros(2): ");
                        opc1 = Convert.ToInt32(Console.ReadLine());
                        if (opc1 == 1)
                        {

                            u.Conversion_P_M(u.Pulgada, out total);
                            Console.WriteLine("{0} Pulgadas= {1} Metros", u.Metro, total);
                            Console.Write("Desea Convertir otra cantidad?, Si(1), No(2): ");
                            opcf = Convert.ToInt32(Console.ReadLine());
                        }

                        else if (opc1 == 2)
                        {

                            u.Conversion_P_C(u.Pulgada, out total);
                            Console.WriteLine("{0} Pulgadas= {1} Centimetros", u.Metro, total);
                            Console.Write("Desea Convertir otra cantidad?, Si(1), No(2): ");
                            opcf = Convert.ToInt32(Console.ReadLine());
                        }
                        break;
                    case 3:
                        Console.Write("Ingrese la cantidad de Centimetros: ");
                        u.centimetro = Convert.ToDouble(Console.ReadLine());
                        Console.Write("A que unidad desea convertir?, Metros(1), Pulhgadas(2): ");
                        opc1 = Convert.ToInt32(Console.ReadLine());
                        if (opc1 == 1)
                        {

                            u.Conversion_C_M(u.centimetro, out total);
                            Console.WriteLine("{0} Centimetros= {1} Metros", u.Metro, total);
                            Console.Write("Desea Convertir otra cantidad?, Si(1), No(2): ");
                            opcf = Convert.ToInt32(Console.ReadLine());
                        }

                        else if (opc1 == 2)
                        {

                            u.Conversion_C_P(u.centimetro, out total);
                            Console.WriteLine("{0} Centimetros= {1} Pulgadas", u.Metro, total);
                            Console.Write("Desea Convertir otra cantidad?, Si(1), No(2): ");
                            opcf = Convert.ToInt32(Console.ReadLine());
                        }
                        break;


                }
            }


        }
    }
}
