using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo; ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem em casa: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preco de um produto: ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu ultimo nome, idade e altura");
            string[] vet = Console.ReadLine().Split(' ');


            // transforma os valores string em variaveis com seus respectivos tipos
            string nome1 = vet[0];
            int i2 = int.Parse(vet[1]);
            double d2 = double.Parse(vet[2]);


            Console.WriteLine(nome);
            Console.WriteLine(i);
            Console.WriteLine(d);
            Console.WriteLine(nome1);
            Console.WriteLine(i2);
            Console.WriteLine(d2);
        }
    }
}

    
