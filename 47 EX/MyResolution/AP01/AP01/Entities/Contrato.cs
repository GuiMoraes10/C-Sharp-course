
namespace AP01.Entities
{
    internal class Contrato
    {
        
        public int Numero {  get; private set; }
        public DateTime Data {  get; private set; }
        public double ValorTotal {  get; private set; }

        public Contrato(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
        }
    }
}
