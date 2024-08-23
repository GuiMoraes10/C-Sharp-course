using ATV1.Entities;
using System;
using System.Runtime.Serialization.Formatters;


namespace ATV1
{
    class program
    {
        public static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Rectangle or Circle (r/c)? ");
                char response = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                string color = Console.ReadLine();

                if (response == 'r')
                {                    
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    list.Add(new Rectangle(color, width, height));                    
                }
                else if(response == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    list.Add(new Circle(color, radius));
                }
            }

            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }

        }
    }
}