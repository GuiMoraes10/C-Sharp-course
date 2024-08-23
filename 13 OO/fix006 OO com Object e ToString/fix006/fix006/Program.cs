using fix006;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto tv = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            tv.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            tv.Valor = double.Parse(Console.ReadLine());

            Console.Write("Quantidade no estoque: ");
            tv.Quantidade = int.Parse(Console.ReadLine());


            // para chamar o ToString, pode apenas colocar o nome do objeto declarado
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


