using Atividade.Entities;

namespace Atividade
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Quantos produtos serão digitados? ");
            int n = int.Parse(Console.ReadLine());

            List<Product> lista = new List<Product>();


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Produto n" + i);
                Console.WriteLine("Digite o tipo de produto ('i' para importado 'u' para usado)");
                char response = char.Parse(Console.ReadLine());

                if (response == 'i')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preco: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write("Taxa de impostos: ");
                    double customsFee = double.Parse(Console.ReadLine());

                    Product prod = new ImportedProduct(nome, preco, customsFee);

                    lista.Add(prod);
                }
                else if (response == 'u')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preco: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.Write("Data de fabricação: ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    Product prod = new UsedProduct(nome, preco, manufactureDate);

                    lista.Add(prod);
                }
                else
                {
                    Console.WriteLine("Digite um tipo válido, produto não cadastrado");
                }
            }

            foreach (Product product in lista)
            {
                Console.WriteLine(product.PriceTag());
            }


        }
    }
}