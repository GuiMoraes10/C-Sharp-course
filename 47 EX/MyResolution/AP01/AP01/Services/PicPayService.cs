
namespace AP01.Services
{
    internal class PicPayService : IServicoDePagamento
    {

        public double Tax(double valor, int mes)
        {
            double valorPorMes = valor + (valor * 0.01 * mes);
            return valorPorMes + (valorPorMes * 0.02);
        }

    }
}
