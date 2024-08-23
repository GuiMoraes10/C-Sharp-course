using System;
using ap017;

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


            Produto p = new Produto(nome, valor);

            // agora e permitido tambem a criacao de um produto sem parametros
            Produto p2 = new Produto();


            Console.WriteLine(p);


            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));


            Console.WriteLine(p);


            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));


            Console.WriteLine(p);


        }
    }
}


