using EX1.Entities;
using System;

namespace EX1
{
    // é comum selar métodos que ja sobrescrevram outros, pois a reutilização deles pode causar inconsistências
    // selar classes garante ganho de performance
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.00, 400.00));
            list.Add(new SavingsAccount(1003, "BOB", 500.00, 0.01));
            list.Add(new BusinessAccount(1004, "Ana", 500.00, 500.00));

            double sum = 0;
            foreach (Account account in list)
            {
                sum += account.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2"));

            foreach (Account account in list)
            {
                account.Withdraw(10.0);
            }

            foreach(Account account in list)
            {
                Console.WriteLine("Updated balance for account " + account.Number + ": " + account.Balance.ToString("F2"));
            }

        }
    }
}