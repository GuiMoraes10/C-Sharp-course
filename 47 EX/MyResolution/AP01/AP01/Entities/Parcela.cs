using System.Globalization;

namespace AP01.Entities
{
    internal class Parcela
    {

        public DateTime DataDeVencimento {  get; private set; }
        public double Valor {  get; private set; }

        public Parcela(DateTime dataDeVencimento, double valor)
        {
            DataDeVencimento = dataDeVencimento;
            Valor = valor;
        }

        public override string ToString()
        {
            return DataDeVencimento.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) +" - "+ Valor;
        }
    }
}
