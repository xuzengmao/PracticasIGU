using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_1b
{
    class Program
    {
        delegate void aviso(int x);

        static void Main(string[] args)
        {
            observador obj = new observador();
            obj.funciona();
        }

        class observador
        {
            TrabajoDuro tb;
            
            public observador()
            {
                tb = new TrabajoDuro();
            }

            public void funciona()
            {
                Console.WriteLine("Vamos a probar el primer tipo de informe");
                tb.ATrabajar(InformeAvanceTipo1);
                Console.WriteLine("Vamos a probar el segundo tipo de informe");
                tb.ATrabajar(InformeAvanceTipo2);
                Console.WriteLine("Terminado");
            }

            public void InformeAvanceTipo1(int x)
            {
                string str = String.Format("Ya llevamos el {0}", x);
                Console.WriteLine(str);
            }

            public void InformeAvanceTipo2(int x)
            {
                Console.WriteLine("***");
            }
        }

       class TrabajoDuro
        {
            int PorcentajeHecho;
            
            public TrabajoDuro()
            {
                PorcentajeHecho = 0;
            }

            public void ATrabajar(aviso callback)
            {
                int i;

                for (i = 0; i < 500; i++) {
                    System.Threading.Thread.Sleep(1);

                    switch (i) {
                        case 125:
                            PorcentajeHecho = 25;
                            if (callback != null)
                                callback(PorcentajeHecho);
                            break;
                        case 250:
                            PorcentajeHecho = 50;
                            if (callback != null)
                                callback(PorcentajeHecho);
                            break;
                        case 375:
                            PorcentajeHecho = 75;
                            if (callback != null)
                                callback(PorcentajeHecho);
                            break;
                    }
                }
            }
        }
    }
}
