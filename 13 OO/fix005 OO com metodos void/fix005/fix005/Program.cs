using fix005;
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


            Console.WriteLine("Dados do produto: " + tv.Nome + ", $" + tv.Valor.ToString("F2") + ", " + tv.Quantidade + ", Total: $" + tv.ValorTotalEmEstoque().ToString("F2"));


            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            tv.AdicionarProdutos(int.Parse(Console.ReadLine()));


            Console.WriteLine("Dados atualizados: " + tv.Nome + ", $" + tv.Valor.ToString("F2") + ", " + tv.Quantidade + ", Total: $" + tv.ValorTotalEmEstoque().ToString("F2"));


            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            tv.RemoverProdutos(int.Parse(Console.ReadLine()));


            Console.WriteLine("Dados atualizados: " + tv.Nome + ", $" + tv.Valor.ToString("F2") + ", " + tv.Quantidade + ", Total: $" + tv.ValorTotalEmEstoque().ToString("F2"));

        }
    }
}


