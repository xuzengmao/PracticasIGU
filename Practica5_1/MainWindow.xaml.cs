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

namespace Practica5_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Color config_color;

        public MainWindow()
        {
            InitializeComponent();
            config_color = ((SolidColorBrush)Lienzo.Background).Color;
        }

        private void MenuItem_Click_configurar(object sender, RoutedEventArgs e)
        {
            CambiaColor cd = new CambiaColor();
            cd.Owner = this;
            cd.C_R = config_color.R;
            cd.C_G = config_color.G;
            cd.C_B = config_color.B;

            cd.ShowDialog();
            
            if (cd.DialogResult == true)
            {
                config_color.R = (byte)cd.C_R;
                config_color.G = (byte)cd.C_G;
                config_color.B = (byte)cd.C_B;
            }

            cd.Close();
            Lienzo.Background = new SolidColorBrush(config_color);
        }

        private void MenuItem_Click_salir(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();
        }
    }
}
