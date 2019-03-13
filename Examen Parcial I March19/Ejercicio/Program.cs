using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la figura que desee operar: ");
            string fig = Console.ReadLine();
            if (fig == "triangulo")
            {
                Triángulo Trian = new Triángulo();
                Trian.NomFigura = "Triángulo";
                Trian.PedirDatos();
                Trian.CalcularArea();
                Trian.VisuaResult();
            }
            if (fig == "rectangulo")
            {
                Rectángulo Rect = new Rectángulo();
                Rect.NomFigura = "Rectángulo";
                Rect.PedirDatos();
                Rect.CalcularArea();
                Rect.VisuaResult();
            }
            if (fig == "circulo")
            {
                Círculo Cir = new Círculo();
                Cir.NomFigura = "Circulo";
                Cir.PedirDatos();
                Cir.CalcularArea();
                Cir.VisuaResult();
            }
            else
            {
                Console.WriteLine("¡Figura no existente!");
            }
            Console.Read();
        }
    }
}
