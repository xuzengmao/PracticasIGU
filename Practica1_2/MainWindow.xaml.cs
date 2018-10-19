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

namespace Practica1_2
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

        private void botonCelsius_Click(object sender, RoutedEventArgs e)
        {
            float temp = System.Convert.ToSingle(CajaTexto.Text);
            Etiqueta.Content = (temp - 32) * 5 / 9;
        }

        private void botonFahrenheit_Click(object sender, RoutedEventArgs e)
        {
            float temp = System.Convert.ToSingle(CajaTexto.Text);
            Etiqueta.Content = 9 / 5.0 * temp + 32;
        }
    }
}
