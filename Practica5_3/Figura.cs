using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Practica5_3
{
    public class Figura
    {
        double x_pos, y_pos;
        double x_des, y_des;
        Shape figura;

        public Figura()
        {
            Random rand = new Random();
            x_pos = rand.Next(300);
            y_pos = rand.Next(300);
            x_des = 1 + rand.Next(30);
            y_des = 1 + rand.Next(30);
            int i = rand.Next(1);

            if (i == 0)
                figura = new Ellipse();
            else
                figura = new Rectangle();

            figura.Fill = new SolidColorBrush(Color.FromArgb((byte)rand.Next(255), (byte)rand.Next(255), (byte)rand.Next(255), (byte)rand.Next(255)));
            figura.Width = 10 + rand.Next(30);
            figura.Height = 10 + rand.Next(30);
        }

        public void mueve(double limite_x, double limite_y)
        {
            if (x_pos + x_des < limite_x)
                x_pos += x_des;
            else
                x_pos = x_pos + x_des - limite_x;

            if (y_pos + y_des < limite_y)
                y_pos += y_des;
            else
                y_pos = y_pos + x_pos - limite_y;
        }

        public double x
        {
            get { return x_pos; }
        }

        public double y
        {
            get { return y_pos; }
        }

        public Shape fig
        {
            get { return figura; }
        }
    }
}
