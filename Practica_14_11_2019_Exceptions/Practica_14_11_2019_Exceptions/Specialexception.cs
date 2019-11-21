using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_14_11_2019_Exceptions
{

    public class Specialexception:ApplicationException
    {
        public Specialexception()
        {

        }
        public Specialexception(string msg):base(msg)
        {
            
        }
    }

}
