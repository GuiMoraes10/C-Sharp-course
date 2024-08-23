using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com as medidas do triangulo x: ");
            double ax = double.Parse(Console.ReadLine());
            double bx = double.Parse(Console.ReadLine());
            double cx = double.Parse(Console.ReadLine());            
            
            
            Console.WriteLine("Entre com as medidas do triangulo y: ");
            double ay = double.Parse(Console.ReadLine());
            double by = double.Parse(Console.ReadLine());
            double cy = double.Parse(Console.ReadLine());


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
                }else
                {
                    return 'Y';
                }
            }

            double areax = calculateArea(ax, bx, cx);
            double areay = calculateArea(ay, by, cy); 

            Console.WriteLine("area de x: " + areax);
            Console.WriteLine("area de y: " + areay);

            char areamaior = comparateArea(areax, areay);

            Console.WriteLine("Maior area: "+ areamaior);

        }
    }
}