using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("digite um numero: ");
            double num = double.Parse(Console.ReadLine());

            //laco wile
            while (num>=0.00)
            {
                num = Math.Sqrt(num);
                //imprime e limita a 3 casas decimais
                Console.WriteLine(num.ToString("F3"));
                Console.WriteLine("digite outro numero: ");
                num = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Numero negativo!");

        }
    }
}
