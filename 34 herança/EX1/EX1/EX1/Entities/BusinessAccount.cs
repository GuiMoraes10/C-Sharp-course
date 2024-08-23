using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1.Entities
{
    // declaro que será uma classe que herda de Account
    internal class BusinessAccount : Account
    {

        public double LoanLimit { get; set; }

        public BusinessAccount() 
        {
        }

        // declara o construtor da subclasse utilizando as atribuições da classe base com o :base(parâmetros do outro construtor)
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base (number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

        public override string ToString()
        {
            return Number + ", " + Holder + ", " + Balance + ", " + LoanLimit;
        }
    }
}
