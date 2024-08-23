using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos numeros inteiros voce vai digitar: ");
            int quant = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1;  i <= quant ; i++) 
            {
                Console.WriteLine("valor #" + i + ":");
                soma = soma + int.Parse(Console.ReadLine());
            }

            Console.WriteLine("soma = " + soma);


        }
    }
}