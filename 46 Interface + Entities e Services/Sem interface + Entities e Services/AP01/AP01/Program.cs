using AP01.Entities;
using AP01.Services;
using System.Globalization;

namespace AP01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface define um conjunto de operacoes que uma classe (ou struct) deve implementar
            // serve para criar sistemas com baixo acoplamento e flexiveis

            // A partir de agora, utilizando separação entre, Entities e Services
            // Entities - Vehicle, CarRental e Invoice
            // Services - RentalService e BrazilTaxService


            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            // recebe a data e hora de uma string no formato passado
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            // declara um CarRental que tem um Vehicle
            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            // declara um RentalService
            RentalService rentalService = new RentalService(hour, day);

            // processa a nota com base no carRental
            rentalService.ProcessInvoice(carRental);


            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}