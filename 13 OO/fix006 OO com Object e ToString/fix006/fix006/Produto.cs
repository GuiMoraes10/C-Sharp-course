using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fix006
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

        // to string do C#
        // override indica que esta operacao veio de outra classe, no caso aqui, da classe Object que possui os metodos ToString() e outros
        public override string ToString()
        {
            return "Dados do produto: " + Nome + ", $" + Valor.ToString("F2") + ", " + Quantidade + ", Total: $" + ValorTotalEmEstoque().ToString("F2");
        }

    }
}
