using System;
using System.Threading.Channels;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá um deósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            double valor = 0;           

            if (resp == 's')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                valor = double.Parse(Console.ReadLine());
            }

            Conta conta = new Conta(titular, numero, valor);

            Console.WriteLine("\nDados da conta:\n" + conta.ToString() + "\n");

            Console.Write("Entre um valor para depósito: ");
            conta.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados:\n" + conta.ToString() + "\n");


            Console.Write("Entre um valor para saque: ");
            conta.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados:\n" + conta.ToString() + "\n");

        }

    }
}


// saque tem uma taxa de $5