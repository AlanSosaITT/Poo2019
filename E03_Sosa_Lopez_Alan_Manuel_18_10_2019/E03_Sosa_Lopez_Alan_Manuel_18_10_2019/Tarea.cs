using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Sosa_Lopez_Alan_Manuel_18_10_2019
{
    public class Tarea
    {
        //Declaracion y encapsulacion de variables
        public Usuario usuario { get; set; }
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Horario { get; set; }
        public DateTime Vencimiento { get; set; }
        public string Estatus { get; set; }
    }
}
