using ap01.Entities;
using System.Net.Sockets;

// ACTION (exemplo com ForEach)

// representa um metodo void que recebe zero ou mais argumentos

namespace Ap01
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));

            // outa forma, declarando o action antes e atribuindo a ele o UpdatePrice
            Action<Product> action = UpdatePrice;

            // passo o metodo UpdatePrice que será o Action, como parametro para cada elemento da lista
            list.ForEach(UpdatePrice);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        // delcaro o metodo que ira atualizar o valor de um produto adicionando 10% do valor dele
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}