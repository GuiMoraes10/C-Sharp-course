using fix003;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo x: ");
            x.l1 = double.Parse(Console.ReadLine());
            x.l2 = double.Parse(Console.ReadLine());
            x.l3 = double.Parse(Console.ReadLine());


            Console.WriteLine("Entre com as medidas do triangulo y: ");
            y.l1 = double.Parse(Console.ReadLine());
            y.l2 = double.Parse(Console.ReadLine());
            y.l3 = double.Parse(Console.ReadLine());

            

            static double calculateArea(double a, double b, double c)
            {
                double p = (a + b + c) / 2;
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return area;
            }

            static char comparateArea(double areax, double areay)
            {
                if (areax > areay)
                {
                    return 'X';
                }
                else
                {
                    return 'Y';
                }
            }

            double areax = calculateArea(x.l1, x.l2, x.l3);
            double areay = calculateArea(y.l1, y.l2, y.l3);

            Console.WriteLine("area de x: " + areax);
            Console.WriteLine("area de y: " + areay);

            char areamaior = comparateArea(areax, areay);

            Console.WriteLine("Maior area: " + areamaior);

        }
    }
}