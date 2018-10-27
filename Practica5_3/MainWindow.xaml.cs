using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Threading;

namespace Practica5_3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Figura> listaFiguras = new ObservableCollection<Figura>();
        DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            this.Show();
            timer = new DispatcherTimer();
            timer.Tick += OnTick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timer.Start();

            CDGenerarFigura cd = new CDGenerarFigura();
            cd.Owner = this;
            cd.AñadirNuevaFigura += Cd_AñadirNuevaFigura;
            cd.Lista.ItemsSource = listaFiguras;
            cd.Show();
        }

        private void Cd_AñadirNuevaFigura(object sender, NuevaFiguraEventArgs e)
        {
            listaFiguras.Add(e.NuevaFigura);
            Lienzo.Children.Add(e.NuevaFigura.fig);
            Canvas.SetLeft(e.NuevaFigura.fig, e.NuevaFigura.x);
            Canvas.SetRight(e.NuevaFigura.fig, e.NuevaFigura.y);
        }

        void OnTick(object sender, EventArgs e)
        {
            foreach(Figura mifig in listaFiguras)
            {
                mifig.mueve(Lienzo.ActualWidth, Lienzo.ActualHeight);
                Canvas.SetLeft(mifig.fig, mifig.x);
                Canvas.SetTop(mifig.fig, mifig.y);
            }
        }


    }
}
