
namespace AP01.Services
{
    internal interface ITaxService
    {
        // a interface será apenas esta linha, pois só define o contrato
        // garante manutenibilidade pois caso existem outros TaxServices além do Brasil, não precisa abrir a classe RenalService

        public double Tax(double amount);        

    }
}
