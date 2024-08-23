using EX1.Entities;
using System;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(0001, "Guilherme de Moraes", 5000.00, 500.00);

            Console.WriteLine(account.Balance);
            Console.WriteLine(account.ToString());
        }
    }
}