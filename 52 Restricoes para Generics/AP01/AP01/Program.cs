using AP01.Entities;
using AP01.Services;
using System;
using System.Globalization;

namespace AP01
{
    class Program
    {
        // as restricoes permitem limitar os tipos de variaveis que podem ser utilizadas para uma classe com generics
        // como neste exemplo onde eles sao limitados apenas a valores que podem ser comparados por maior, menor ou igual
        static void Main(string[] args)
        {
            
            List <Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);

                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("Max:");
            Console.WriteLine(max);

        }
    }        
}