using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4_1
{
    class amigo
    {
        public string nombre { get; set; }
        public string apell { get; set; }
        public int edad { get; set; }
        public amigo (string n, string a, int e)
        {
            nombre = n;
            apell = a;
            edad = e;
        }
    }
}
