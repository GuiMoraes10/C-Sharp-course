using ap01.Entities;

// PREDICATE (exemplo com removeAll)

// representa um metodo que recebe um objeto do tipo T e retorna um valor booleano

namespace Ap01
{


    class Program
    {
        // fazer um programa para que remova da lista apenas os produtos que possuem o preco minimo de 100
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));

            // removeAll recebe um predicate como parametro, que é um metodo que vai retornar um booleano com base em alguma funcao
            list.RemoveAll(ProductTest);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        // declaro o metodo ProductTest que ira retornar o booleano com base no Product
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }

    }
}