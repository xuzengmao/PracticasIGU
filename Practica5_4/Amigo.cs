using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5_4
{
    class Amigo
    {
        string nombre_base;
        string apellido_base;
        int edad_base;

        public string nombre
        {
            get { return nombre_base; }
            set { nombre_base = value; }
        }

        public string apellido
        {
            get { return apellido_base; }
            set { apellido_base = value; }
        }

        public Amigo(string nom, string ape)
        {
            nombre_base = nom;
            apellido_base = ape;
            edad_base = 10;
        }
    }
}
