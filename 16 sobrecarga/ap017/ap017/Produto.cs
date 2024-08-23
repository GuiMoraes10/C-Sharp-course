using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap017
{
    internal class Produto
    {
        public string Nome;
        public double Valor;
        public int Quantidade;

        public Produto(string nome, double valor, int quantidade)
        {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        // mais um construtor, porem recebendo apenas o nome e o valor, a quantidade por padrao ficara 0
        public Produto (string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        // permite a criacao de um construtor sem nenhum parametro
        public Produto()
        {

        }

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


        public override string ToString()
        {
            return "Dados do produto: " + Nome + ", $" + Valor.ToString("F2") + ", " + Quantidade + ", Total: $" + ValorTotalEmEstoque().ToString("F2");
        }

    }
}