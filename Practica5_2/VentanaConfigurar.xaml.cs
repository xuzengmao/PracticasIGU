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

namespace Practica5_2
{

    public class CambioColorEventArgs : EventArgs
    {
        public Color ColorCambiado;
    }

    public delegate void CambioColorEventHandler(object sender, CambioColorEventArgs e);

    /// <summary>
    /// Lógica de interacción para VentanaConfigurar.xaml
    /// </summary>
    public partial class VentanaConfigurar : Window
    {
        public event CambioColorEventHandler CambioColor;
        Color color_admin;

        public int C_R
        {
            get { return color_admin.R; }
            set { color_admin.R = (byte)value; RedSlider.Value = value; }
        }

        public int C_G
        {
            get { return color_admin.G; }
            set { color_admin.G = (byte)value; GreenSlider.Value = value; }
        }

        public int C_B
        {
            get { return color_admin.B; }
            set { color_admin.B = (byte)value; BlueSlider.Value = value; }
        }

        public VentanaConfigurar()
        {
            InitializeComponent();
        }

        void OnCambioColor(CambioColorEventArgs e)
        {
            if (this.CambioColor != null)
                this.CambioColor(this, e);
        }

        private void Window_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            color_admin = Color.FromRgb((byte)Math.Round(RedSlider.Value, 0),
                                        (byte)Math.Round(GreenSlider.Value),
                                        (byte)Math.Round(BlueSlider.Value));

            CambioColorEventArgs argumentos = new CambioColorEventArgs();
            argumentos.ColorCambiado = color_admin;
            OnCambioColor(argumentos);
        }

        private void Quit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
