using System;
using System.Collections.Generic;
using System.Linq;


namespace EX1.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; } // o protected indica que eu posso utilizar o set do Balance somente na classe e em suas subclasses, permitindo usar em BusinessAccount

        public Account()
        {

        }

        public Account (int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // indica que é um método que pode ser sobreescrito por uma subclasse
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public override string ToString()
        {
            return Number + ", " + Holder + ", " + Balance;
        }
    }
}
