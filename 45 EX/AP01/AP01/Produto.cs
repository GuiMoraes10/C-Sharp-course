using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP01
{
    internal class Produto
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double getValor(double preco, int quantidade)
        {
            return preco * quantidade;
        }

        public override string ToString()
        {
            return Nome +";"+ getValor(Preco, Quantidade); 
        }

    }
}
