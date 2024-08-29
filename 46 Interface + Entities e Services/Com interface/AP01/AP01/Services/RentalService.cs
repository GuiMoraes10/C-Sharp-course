
using AP01.Entities;

namespace AP01.Services
{
    internal class RentalService
    {

        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        // agora ao invés de instanciar a própria dependência de taxService, ela recebe o taxService junto com o construtor da classe
        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {

            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0;

            // TotalHours pega as horas totais de um TimeSpan
            if (duration.TotalHours <= 12)
            {
                // Math.Ceiling arredonda para cima
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);

        }

    }
}
