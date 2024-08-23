using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap019
{
    internal class Produto
    {

        // este encapsulamento nao é muito comum em C# pois ja existe o Properties (proximo arquivo)


        // colocar atributo como private indica que este atributo só pode ser acessado dentro desta classe
        // quando se utiliza o private, por convenção, deve se usar os atributos da classe da seguinte forma: _nome, _valor, etc
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


        // agora como os atributos estao em private, se utiliza gets e sets para receber e alterar os valores
        public string GetNome()
        {
            return _nome;
        }

        // no set posso incluir ifs por exemplo
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetValor()
        {
            return _valor;
        }

        public int GetQuantidade()
        {
            return _quantidade;
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