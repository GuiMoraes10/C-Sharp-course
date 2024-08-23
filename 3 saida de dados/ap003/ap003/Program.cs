using System;
using System.Globalization;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            // WriteLine inclui uma quebra de linhas no final, já o Write não
            Console.Write("nome1");
            Console.WriteLine("nome2");
            Console.WriteLine("nome3");
            Console.WriteLine("--------------------------");

            char genero = 'M';
            int idade = 21;
            double saldo = 10.35784;
            string nome = "Guilherme";

            Console.WriteLine(genero);
            Console.WriteLine(idade);

            // limita o double para 2 casas decimais
            Console.WriteLine(saldo.ToString("F2"));
            // limita para 4 casas decimais
            Console.WriteLine(saldo.ToString("F4"));

            // formata o padrao para o americano na , ou .
            // deve importar o using System.Globalization
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);

        }
    }
}
