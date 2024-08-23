using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fix005
{
    internal class Produto
    {
        public string Nome;
        public double Valor;
        public int Quantidade;
        
        public double ValorTotalEmEstoque()
        {
            return Valor * Quantidade;
        }

        public void AdicionarProdutos(int quant)
        {
            Quantidade += quant;
        }

        public void RemoverProdutos(int quant)
        {
            Quantidade -= quant;
        }

    }
}
