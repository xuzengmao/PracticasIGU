using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Practica5_3
{
    public class NuevaFiguraEventArgs : EventArgs
    {
        public Figura NuevaFigura { get; set; }
    }

    public delegate void NuevaFiguraEventArgsHandler(Object sender, NuevaFiguraEventArgs e);

    public partial class CDGenerarFigura : Window
    {
        public event NuevaFiguraEventArgsHandler AñadirNuevaFigura;

        public CDGenerarFigura()
        {
            InitializeComponent();
        }

        private void NuevaFiguraButton_Click(object sender, RoutedEventArgs e)
        {
            Figura fig = new Figura();
            NuevaFiguraEventArgs args = new NuevaFiguraEventArgs();
            args.NuevaFigura = fig;
            OnAñadirNuevaFigura(args);
        }

        void OnAñadirNuevaFigura(NuevaFiguraEventArgs e)
        {
            if (AñadirNuevaFigura != null)
            {
                AñadirNuevaFigura(this, e);
                Console.WriteLine("hoal");
            }
        }

        
    }
}
