using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_2
{
    class Acopladas
    {
        static void Main(string[] args)
        {
            observador obj = new observador();
            obj.funciona();

            /*
            otroObservador obj = new otroObservador();
            */
        }
    }
    class observador
    {
        TrabajoDuro tb;
        public observador() { tb = new TrabajoDuro(/*this*/); }
        public void funciona()
        {
            TipoDelegado objdelg;
            Console.WriteLine("Vamos a probar el informe");
            objdelg = InformeAvance;
            objdelg += InformeAvance2;
            tb.ATrabajar(objdelg);
            Console.WriteLine("Terminado");
        }
        public void InformeAvance(int x)
        {
            string str = String.Format("Ya llevamos el {0}", x);
            Console.WriteLine(str);
        }

        void InformeAvance2(int x)
        {
            string str = String.Format("***");
            Console.WriteLine(str);
        }
    }

    class otroObservador
    {
        TrabajoDuro mitrab = new TrabajoDuro(); // El la primera solución: No se reutiliza, no se puede utilizar con otro trabajador.
        public otroObservador()
        {
            mitrab.ATrabajar(loqueyodigo);
        }

        void loqueyodigo(int x)
        {
            Console.Write("********\n");
        }
    }

    delegate void TipoDelegado(int v);

    class TrabajoDuro
    {
        int PocentajeHecho;
        //observador eljefe;

        public event TipoDelegado alcanzadoporcentaje;
        public TrabajoDuro(/*observador o*/)
        {
            PocentajeHecho = 0;
            //eljefe = o;
        }
        public void ATrabajar(TipoDelegado mideleg)
        {
            int i;
            for (i = 0; i < 500; i++)
            {
                System.Threading.Thread.Sleep(1); //Hacemos el trabajo
                switch (i)
                {
                    case 125:
                        PocentajeHecho = 25;
                        if (mideleg != null)
                            mideleg(PocentajeHecho);
                        break;
                    case 250:
                        PocentajeHecho = 50;
                        if (mideleg != null)
                            mideleg(PocentajeHecho);
                        break;
                    case 375:
                        PocentajeHecho = 75;
                        if (mideleg != null)
                            mideleg(PocentajeHecho);
                        break;
                }
            }
        }
    }
}
