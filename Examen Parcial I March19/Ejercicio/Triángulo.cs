using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Triángulo:Figura
    {
        public double BaseTri { get; set; }
        public double AlturaTri { get; set; }
        public double AreaTri { get; set; }

        public void PedirDatos()
        {
            Console.WriteLine("Ingrese datos para el Triángulo: ");
            Console.WriteLine();
            Console.WriteLine("Ingrese base: ");
            BaseTri = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese altura: ");
            AlturaTri = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese área: ");
            AreaTri = Convert.ToDouble(Console.ReadLine());
        }
        public void CalcularArea()
        {
            double área = (BaseTri * AlturaTri) / 2;
            Console.WriteLine("La base del triángulo es: " + área);
            Console.WriteLine();
        }
        public void VisuaResult()
        {
            Console.WriteLine("La base es:" +BaseTri);
            Console.WriteLine("La altura es: "+AlturaTri);
            Console.WriteLine("El área es: "+AreaTri);
        }
    }
}
    