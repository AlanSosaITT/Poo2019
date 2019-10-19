using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Sosa_Lopez_Alan_Manuel_18_10_2019
{
    public class Usuario
    {
        //Declaracion e incapsulacion de variables
        public int ID { get; set; }
        public string Nombre { get; set; }
        public List<Tarea> tareas = new List<Tarea>();
    }
}
