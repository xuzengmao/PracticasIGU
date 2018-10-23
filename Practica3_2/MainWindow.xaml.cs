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

namespace Practica3_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Polyline polilinea = new Polyline();
            polilinea.Stroke = Brushes.Red;
            Lienzo.Children.Add(polilinea);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Polyline polilinea = (Polyline)Lienzo.Children[0];
            polilinea.Points.Add(e.GetPosition(Lienzo));
            Lienzo.Children.RemoveAt(0);
            Lienzo.Children.Add(polilinea);
        }
    }
}
