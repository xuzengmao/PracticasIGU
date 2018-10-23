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

namespace Practica3_3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Collection<Figura> listafiguras = new Collection<Figura>();
        DispatcherTimer timer;
        bool flag = true;

        public object Static { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += OnTick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
        }

        private void OnTick(object sender, EventArgs e)
        {
            foreach (Figura mifig in listafiguras)
            {
                mifig.mueve(Lienzo.ActualWidth, Lienzo.ActualHeight);
                Canvas.SetLeft(mifig.fig, mifig.x);
                Canvas.SetTop(mifig.fig, mifig.y);
            }
        }

        private void CrearFigura_Click(object sender, RoutedEventArgs e)
        {
            Figura figura = new Figura(Lienzo.ActualWidth, Lienzo.ActualHeight);
            listafiguras.Add(figura);
            Lienzo.Children.Add(figura.fig);
            Canvas.SetLeft(figura.fig, figura.x);
            Canvas.SetTop(figura.fig, figura.y);
        }

        private void Animar_Click(object sender, RoutedEventArgs e)
        {
            if(flag)
            {
                timer.Start();
                Animar.Content = "Parar";
                flag = false;
            }
            else
            {
                timer.Stop();
                Animar.Content = "Animar";
                flag = true;
            }
        }
    }
}
