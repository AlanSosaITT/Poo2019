using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Sosa_lopez_Alan_Manuel_To_do_list
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public List<Tarea> tareas = new List<Tarea>();
    }
}
