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

namespace Practica5_4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Amigo> coleccionAmigos;

        public MainWindow()
        {
            InitializeComponent();
            coleccionAmigos = new ObservableCollection<Amigo>();
            CuadroLista.ItemsSource = coleccionAmigos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Amigo nuevoAmigo = new Amigo(BoxNom.Text, BoxApe.Text);
            coleccionAmigos.Add(nuevoAmigo);
        }
    }
}
