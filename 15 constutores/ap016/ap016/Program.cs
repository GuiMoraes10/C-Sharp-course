using ap016;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double valor = double.Parse(Console.ReadLine());

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            // cria o objeto ja com os seus respectivos atributos
            Produto tv = new Produto(nome, valor, quantidade);


            Console.WriteLine(tv);


            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            tv.AdicionarProdutos(int.Parse(Console.ReadLine()));


            Console.WriteLine(tv);


            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            tv.RemoverProdutos(int.Parse(Console.ReadLine()));


            Console.WriteLine(tv);
            

        }
    }
}


