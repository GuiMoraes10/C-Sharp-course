

namespace EX1.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        // faz o saldo * a taxa de juros
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // indica que é uma sobreposição do método withdraw da superclasse
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
