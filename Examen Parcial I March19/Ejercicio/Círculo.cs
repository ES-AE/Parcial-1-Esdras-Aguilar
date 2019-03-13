using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Círculo:Figura
    {
        public double RadioCir { get; set; }
        public double AreaCir { get; set; }
        public void PedirDatos()
        {
            Console.WriteLine("Ingrese datos para el Círculo: ");
            Console.WriteLine();
            Console.WriteLine("Ingrese radio del círculo: ");
            RadioCir = Convert.ToDouble(Console.ReadLine());
        }
        public void CalcularArea()
        {
            double pi = 3.1416;
            double área = (pi*(Math.Pow(RadioCir,2)));
            Console.WriteLine("La base del círculo es: " + área);
            Console.WriteLine();
        }
        public void VisuaResult()
        {
            Console.WriteLine("El radio es:" + RadioCir);
        }
    }
}
