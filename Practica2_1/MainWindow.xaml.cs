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

namespace Practica2_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += Window_KeyDown;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            int aux;

            switch (e.Key)
            {
                case Key.Right:
                    aux = Grid.GetColumn(rect);

                    if (aux < grid.ColumnDefinitions.Count - 1)
                        Grid.SetColumn(rect, aux + 1);
                    else
                        Grid.SetColumn(rect, 0);

                    break;
                case Key.Left:
                    aux = Grid.GetColumn(rect);

                    if (aux > 0)
                        Grid.SetColumn(rect, aux - 1);
                    else
                        Grid.SetColumn(rect, grid.ColumnDefinitions.Count - 1);

                    break;
                case Key.Down:
                    aux = Grid.GetRow(rect);

                    if (aux < grid.RowDefinitions.Count - 1)
                        Grid.SetRow(rect, aux + 1);
                    else
                        Grid.SetRow(rect, 0);

                    break;
                case Key.Up:
                    aux = Grid.GetRow(rect);

                    if (aux > 0)
                        Grid.SetRow(rect, aux - 1);
                    else
                        Grid.SetRow(rect, grid.RowDefinitions.Count - 1);
                    break;
            }
            /*
            if (e.Key == Key.Right && oldColumn < 7)
                Grid.SetColumn(rect, oldColumn + 1);
            else if (e.Key == Key.Left && oldColumn > 0)
                Grid.SetColumn(rect, oldColumn - 1);
            else if (e.Key == Key.Down && oldRow < 7)
                Grid.SetRow(rect, oldRow + 1);
            else if (e.Key == Key.Up && oldRow > 0)
                Grid.SetRow(rect, oldRow - 1);
            */
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            RotateTransform rt;
            rt = (RotateTransform) rect.LayoutTransform;
            rt.Angle += 10;
        }
    }
}
