using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_29_10_2019_Cocina
{
    public class Platillo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        

    }
    interface Imenu
    {
        void Create_menu();
        void List_menu();
        void Details();
    }
}
