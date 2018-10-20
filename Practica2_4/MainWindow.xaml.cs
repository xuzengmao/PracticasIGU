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

namespace Practica2_4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static float factor_ED = 1.30F;

        public MainWindow()
        {
            InitializeComponent();
            Dolar.KeyDown += new KeyEventHandler(Euro_KeyDown);
            Euro.KeyDown += new KeyEventHandler(Euro_KeyDown);
        }

        private void Euro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                if (sender == Euro)
                    Dolar.Text = ((Euro.DoubleValue * factor_ED)).ToString();
                else if (sender == Dolar)
                    Euro.Text = ((Dolar.DoubleValue / factor_ED)).ToString();
        }
    }
}
