using fix004;
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


            static char ComparateArea(double areax, double areay)
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

            double areax = x.CalculateArea();
            double areay = y.CalculateArea();

            Console.WriteLine("area de x: " + areax);
            Console.WriteLine("area de y: " + areay);

            char areamaior = ComparateArea(areax, areay);

            Console.WriteLine("Maior area: " + areamaior);

        }
    }
}