using System;
using System.Windows;
using System.Windows.Controls;
namespace Proyectos.ElSegundo
{
    class Basica
    {
        [STAThread]
        public static void Main()
        {
            Console.WriteLine("EMPEZANDO");
            Window win = new Window();
            win.Title = "Segundo Programa";
            win.Show();
            Console.WriteLine("Ventana abierta");
            Label etiqueta = new Label();
            etiqueta.Content = "Hola Mundo";
            win.Content = etiqueta;
            Application app = new Application();
            Console.WriteLine("Esperando que pase algo");
            app.Run();
            Console.WriteLine("se acabó");
        }
    }
}