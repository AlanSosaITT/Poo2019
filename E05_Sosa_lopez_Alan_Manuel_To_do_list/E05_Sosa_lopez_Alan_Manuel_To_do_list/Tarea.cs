﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Sosa_lopez_Alan_Manuel_To_do_list
{
    public class Tarea
    {
        public Usuario usuario { get; set; }
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Horario { get; set; }
        public string Estatus { get; set; }
    }
}
