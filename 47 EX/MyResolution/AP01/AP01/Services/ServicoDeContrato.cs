
using AP01.Entities;

namespace AP01.Services
{
    internal class ServicoDeContrato
    {

        public Parcela[] ProcessarContrato(int mesesTotais, Contrato contrato, IServicoDePagamento servicoDePagamento)
        {
            Parcela[] parcelas = new Parcela[mesesTotais];
            double valorParcelaBase = contrato.ValorTotal / mesesTotais;

            for (int i = 1; i <= mesesTotais; i++)
            {
                DateTime dataDeVencimento = contrato.Data.AddMonths(i);
                double valor = servicoDePagamento.Tax(valorParcelaBase, i);

                parcelas[i - 1] = new Parcela(dataDeVencimento, valor);
            }

            return parcelas;
        }

    }
}
