using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap018
{
    internal class Produto
    {

        // usar o this para referenciar um atributo de um metodo com um de fora nao é muito comum em C#
        // pois em C# ja é adotado um padrao de letras maiusculas nos atributos de Classes e minusculas nos de metodos

        // this tambem é utilizado para passar o proprio objeto da classe como parametro de um atributo de dentro dela
        // é adicionado entao apenas um (nome, preco , this) para dizer que o próprio objeto sera um dos parametros


        public string Nome;
        public double Valor;
        public int Quantidade;


        public Produto()
        {
            Quantidade = 10;
        }


        // com esse this () eu reaproveito o codigo do construtor padrao Produto()
        // e indico que Quantidade = 10 tambem vale para este construtor
        public Produto(string nome, double valor) : this() 
        {
            Nome = nome;
            Valor = valor;
        }


        // mesma coisa que o anterior mas indicando que nome e preco terao o mesmo comportamento
        // de nome e preco do construtor referenciado
        public Produto (string nome, double preco, int quantidade) :this(nome, preco) 
        {
            Quantidade = quantidade;
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