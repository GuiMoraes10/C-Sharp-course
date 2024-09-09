using System;

namespace AP01
{
    class Program
    {
        // Generics - permitem que classes, interfaces e metodos sejam parametrizados por tipo
        // gera reuso, type safety e performance

        // Problema 1 com reuso
        // tem problema com reuso pois pode receber apenas valores de int, e não string por exemplo
        static void Main(string[] args)
        {

            PrintService printService = new PrintService();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}