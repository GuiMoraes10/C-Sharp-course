using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap021
{
    class Produto
    {

        // neste caso apenas o nome nao tera auto properties pois ele tem uma logica particular
        private string _nome;

        // no auto properties eu volto o atributo para public, volto a primeira letra para maiuscula
        // coloco o seu get e set direto na declaração
        // alem de indicar que apenas seu set será private
        public double Valor { get; private set; }
        public int Quantidade {  get; private set; }


        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Quantidade = quantidade;
            Valor = preco;
        }


        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
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
            return "Dados do produto: " + _nome + ", $" + Valor.ToString("F2") + ", " + Quantidade + ", Total: $" + ValorTotalEmEstoque().ToString("F2");
        }

    }
}