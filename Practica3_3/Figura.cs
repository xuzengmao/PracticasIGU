using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Practica3_3
{
    class Figura
    {
        double x_pos, y_pos;
        double x_des, y_des;
        Shape figura;

        public Figura(double limite_x, double limite_y)
        {
            Random rand = new Random();
            x_pos = rand.Next((int)limite_x);
            y_pos = rand.Next((int)limite_y);
            x_des = rand.Next((int)limite_x / 20);
            y_des = rand.Next((int)limite_y / 20);
            int i = rand.Next(1);

            if (i == 0)
                figura = new Ellipse();
            else
                figura = new Rectangle();

            figura.Fill = new SolidColorBrush(Color.FromArgb((byte)rand.Next(255), (byte)rand.Next(255), (byte)rand.Next(255), (byte)rand.Next(255)));
            figura.Width = 10 + rand.Next((int)limite_y / 20);
            figura.Height = 10 + rand.Next((int)limite_y / 20);
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
