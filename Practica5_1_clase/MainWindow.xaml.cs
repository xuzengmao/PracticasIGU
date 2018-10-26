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

namespace Practica5_1_clase
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

        private void MenuItem_Click_Configurar(object sender, RoutedEventArgs e)
        {
            VentanaConfigurar cd = new VentanaConfigurar();
            cd.Owner = this;
            cd.HaCambiadoCadena += Cd_HaCambiadoCadena;
            cd.textBox.Text = this.Title;

            cd.Show();
        }

        private void Cd_HaCambiadoCadena(object sender, CambiosCadenaEventArgs e)
        {
            this.Title = e.LaCadena;
        }

        private void MenuItem_Click_Salir(object sender, RoutedEventArgs e)
        {

        }
    }
}
