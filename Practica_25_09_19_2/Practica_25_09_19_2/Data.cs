using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_25_09_19_2
{
    class Data
    {
        private double ladoa;
        private double ladob;
        private double ladoc;

        public double Ladoa
        {
            get { return ladoa; }
            set { ladoa = value; }
        }
        public double Ladob
        {
            get { return ladob; }
            set { ladob = value; }
        }
        public double Ladoc
        {
            get { return ladoc; }
            set { ladoc = value; }
        }
        public double Area(double x)
        {
            x *= x;
            return x;
        }
        public double Area(double x,double y)
        {
            x = x * y;
            return x;
        }
        public double Area(double x,double y, double z)
        {
            x = (x * y) / z;
            return x;
        }
    }
}
