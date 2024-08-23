using System;
using System.IO.Pipes;
using System.Globalization;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 21;
            double saldo = 10.35784;
            string nome = "Guilherme";

            //Placeholder
            // :F2 indica 2 casas decimais
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            //Interpolacao
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            //Concatenacao
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");


            //ex
            string prod1 = "Computador";
            string prod2 = "Mesa";

            byte idade1 = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"Produtos:\nComputador, cujo preco e ${preco1}\nMesa de escritorio, cujo preco e $ {preco2}");
            Console.WriteLine($"\nRegistro: {idade} anos de idade, codigo {codigo} e genero: {genero}");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (tres casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

