using ATV2.Entities;
using System;

namespace ATV2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Pessoa> list = new List<Pessoa> ();
            double totalTaxes = 0.0;

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Tax payer #" + i + " data:");

                Console.Write("Individual or company (i/c)? ");
                char response = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double rent = double.Parse(Console.ReadLine());

                if (response == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine());

                    list.Add(new PessoaFisica(name, rent, expenditures));
                }
                else if (response == 'c')
                {
                    Console.Write("Number of employees: ");
                    int number = int.Parse(Console.ReadLine());

                    list.Add(new PessoaJuridica(name, rent, number));
                }
            }

            foreach(Pessoa pessoa in list)
            {
                Console.WriteLine(pessoa.Nome + ": $" + pessoa.Imposto().ToString("F2"));
                totalTaxes += pessoa.Imposto();
            }

            Console.WriteLine("\nTOTAL TAXES: $" + totalTaxes.ToString("F2"));
        }
    }
}