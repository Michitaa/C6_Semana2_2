using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6_Semana2_2 
{
    class Program
{
    static void Main(string[] args)
        {
            var miRectangulo = new Rectangulo(10, 5);

            double area = miRectangulo.CalcularArea();

            Console.WriteLine($"El área del rectángulo es: {area}");

            Console.ReadKey();
        }
    }
}
