using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Rectángulo:Figura
    {
        public double BaseRec { get; set; }
        public double AlturaRec { get; set; }
        public double AreaRec { get; set; }
        public void PedirDatos()
        {
            Console.WriteLine("Ingrese datos para el Triángulo: ");
            Console.WriteLine();
            Console.WriteLine("Ingrese base: ");
            BaseRec = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese altura: ");
            AlturaRec = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese área: ");
            AreaRec = Convert.ToDouble(Console.ReadLine());
        }
        public void CalcularArea()
        {
            double área = (BaseRec * AlturaRec);
            Console.WriteLine("La base del triángulo es: " + área);
            Console.WriteLine();
        }
        public void VisuaResult()
        {
            Console.WriteLine("La base es:" + BaseRec);
            Console.WriteLine("La altura es: " + AlturaRec);
            Console.WriteLine("El área es: " + AreaRec);
        }
    }
}
