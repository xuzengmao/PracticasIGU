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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practica3_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int numpuntos = (int) lienzo.ActualWidth;
            Polyline funcion = new Polyline();
            PointCollection puntos = new PointCollection();
            float xminreal = -10, xmaxreal = 10;
            float yminreal = -10, ymaxreal = 110;
            float xreal, yreal, xpant, ypant;
            float xminpant = 0, xmaxpant = numpuntos;
            float yminpant = 0, ymaxpant = (float) lienzo.ActualHeight;

            for (int i = 0; i < numpuntos; i++)
            {
                xreal = xminreal + i * (xmaxreal - xminreal) / numpuntos;
                yreal = xreal * xreal;
                xpant = (xmaxpant - xminpant) * (xreal - xminreal) / (xmaxreal - xminreal) + xminpant;
                ypant = (yminpant - ymaxpant) * (yreal - yminreal) / (ymaxreal - yminreal) + ymaxpant;
                Point pt = new Point(xpant, ypant);
                puntos.Add(pt);
            }

            funcion.Points = puntos;
            funcion.Stroke = Brushes.Red;
            lienzo.Children.Add(funcion);
        }
    }
}
