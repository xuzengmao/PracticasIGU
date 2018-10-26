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

namespace Practica5_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Color config_color;
        VentanaConfigurar cd;

        public MainWindow()
        {
            InitializeComponent();
            config_color = ((SolidColorBrush)Lienzo.Background).Color;
        }

        private void MenuItem_Click_configurar(object sender, RoutedEventArgs e)
        {
            cd = new VentanaConfigurar();
            cd.Owner = this;
            cd.C_R = config_color.R;
            cd.C_G = config_color.G;
            cd.C_B = config_color.B;
            cd.CambioColor += cd_CambioColor;
            cd.Show();
        }

        private void MenuItem_Click_salir(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();
        }

        void cd_CambioColor(object sender, CambioColorEventArgs e)
        {
            config_color = e.ColorCambiado;
            Brush brocha = new SolidColorBrush(config_color);
            Lienzo.Background = brocha;
        }
    }
}