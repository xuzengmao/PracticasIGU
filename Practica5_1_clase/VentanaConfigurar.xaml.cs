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

namespace Practica5_1_clase
{
    /// <summary>
    /// Lógica de interacción para VentanaConfiguar.xaml
    /// </summary>
    
    public class CambiosCadenaEventArgs : EventArgs
    {
        public string LaCadena { get; set; }
    }

    public delegate void CambiosCadenaEventHandler(Object sender, CambiosCadenaEventArgs e);

    public partial class VentanaConfigurar : Window
    {
        public event CambiosCadenaEventHandler HaCambiadoCadena;

        public VentanaConfigurar()
        {
            InitializeComponent();
        }

        void OnHaCambiadoCadena (CambiosCadenaEventArgs e)
        {
            if (HaCambiadoCadena != null)
            {
                HaCambiadoCadena(this, e);
            }
        }

        private void Cerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CambiosCadenaEventArgs arg = new CambiosCadenaEventArgs();
            arg.LaCadena = textBox.Text;
            OnHaCambiadoCadena(arg);
        }
    }
}
