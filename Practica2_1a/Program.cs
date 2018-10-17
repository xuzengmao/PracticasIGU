using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAcopladas
{
    class Acopladas
    {
        static void Main(string[] args)
        {
            observador obj = new observador();
            obj.funciona();
        }
    }

    class observador
    {
        TrabajoDuro tb;
        public observador()
        {
            tb = new TrabajoDuro(this);
        }

        public void funciona()
        {
            Console.WriteLine("Vamos a probar el informe");
            tb.ATrabajar();
            Console.WriteLine("Terminado");
        }

        public void InformeAvance(int x)
        {
            string str = String.Format("Ya llevamos el {0}", x);
            Console.WriteLine(str);
        }
    }

    class TrabajoDuro
    {
        int PorcentajeHecho;
        observador eljefe;

        public TrabajoDuro(observador o)
        {
            PorcentajeHecho = 0;
            eljefe = o;
        }

        public void ATrabajar()
        {
            int i;

            for (i = 0; i < 500; i++)
            {
                System.Threading.Thread.Sleep(1);
                switch (i)
                {
                    case 125:
                        PorcentajeHecho = 25;
                        eljefe.InformeAvance(PorcentajeHecho);
                        break;
                    case 250:
                        PorcentajeHecho = 50;
                        eljefe.InformeAvance(PorcentajeHecho);
                        break;
                    case 375:
                        PorcentajeHecho = 75;
                        eljefe.InformeAvance(PorcentajeHecho);
                        break;
                }
            }
        }
    }
}
