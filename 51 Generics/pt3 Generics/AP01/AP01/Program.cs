using System;

namespace AP01
{
    class Program
    {
        // Generics - permitem que classes, interfaces e metodos sejam parametrizados por tipo
        // gera reuso, type safety e performance

        // Problema 3 com Generics
        static void Main(string[] args)
        {
            // desta forma eu posso declarar o objeto indicando qual sera o tipo do valor utilizado
            PrintService<int> printService = new PrintService<int>();

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