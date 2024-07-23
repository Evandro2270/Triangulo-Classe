using System;
using System.Globalization;
using Triangulo_Classe;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                Triangulo x, y;
                x = new Triangulo();
                y = new Triangulo();

                Console.WriteLine("Entre com as medidas do triangulo x:");
                x.A = double.Parse(Console.ReadLine(), CI);
                x.B = double.Parse(Console.ReadLine(), CI);
                x.C = double.Parse(Console.ReadLine(), CI);

                Console.WriteLine("Entre com as medidas do triangulo x:");
                y.A = double.Parse(Console.ReadLine(), CI);
                y.B = double.Parse(Console.ReadLine(), CI);
                y.C = double.Parse(Console.ReadLine(), CI);

                double p = (x.A + x.B + x.C) / 2.0;
                double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

                p = (y.A + y.B + y.C) / 2.0;
                double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

                Console.WriteLine("Area de X = " + areaX.ToString("F4", CI));
                Console.WriteLine("Area de Y = " + areaY.ToString("F4", CI));

                if (areaX > areaY)
                {
                    Console.WriteLine("Maior área : X");
                }
                else
                {
                    Console.WriteLine("Maior área : Y");
                }

            }
        }
    }
}
