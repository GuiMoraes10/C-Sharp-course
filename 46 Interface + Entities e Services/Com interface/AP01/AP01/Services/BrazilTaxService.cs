
namespace AP01.Services
{
    // indico que BrazilTaxService é um subtitulo de ITaxService
    internal class BrazilTaxService : ITaxService
    {       
        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }

    }
}
