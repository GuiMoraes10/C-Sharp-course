using System;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            // quantidade de quartos que podem ser alugados
            Pessoa[] p =  new Pessoa[10];
            Console.Write("Quantos quartos serão alugados? ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Aluguel #" + (i+1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto =  int.Parse(Console.ReadLine());

                p[quarto] = new Pessoa(nome, email, quarto);
            }

            Console.WriteLine("Quartos ocupados:");

            for (int i = 0;i < 10; i++)
            {
                if (p[i] != null)
                {
                    Console.WriteLine(p[i].ToString());
                }
            }
        }
    }
}