using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap020
{
    class Produto
    {

        private string _nome;
        private double _valor;
        private int _quantidade;


        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _quantidade = quantidade;
            _valor = preco;
        }

        // no C# utiliza se o get e set desta forma, indicando um public string nome e seu get e set
        // no set o "Nome" que era adicionado ao valor de _nome, value
        // indicando entao que é o valor que sera passado no set
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

        public double Valor
        {
            get
            {
                return _valor;
            }
            set
            {
                _valor = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return _quantidade;
            }
            set
            {
                _quantidade = value;
            }
        }


        public double ValorTotalEmEstoque()
        {
            return _valor * _quantidade;
        }

        public void AdicionarProdutos(int quant)
        {
            _quantidade += quant;
        }

        public void RemoverProdutos(int quant)
        {
            _quantidade -= quant;
        }


        public override string ToString()
        {
            return "Dados do produto: " + _nome + ", $" + _valor.ToString("F2") + ", " + _quantidade + ", Total: $" + ValorTotalEmEstoque().ToString("F2");
        }

    }
}