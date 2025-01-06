using ap01.Entities;
using System.Linq;

// FUNC (exemplo com select)

// representa um metodo que recebe zero ou mais argumentos, e retorna um valor

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

            // outra forma de declarar o Func antes de passar para a nova lista
            Func<Product, string> func = NameUpper;

            // salva em uma no-va lista os valores em caixa alta recebendo como parametro um Func
            List<string> result = list.Select(NameUpper).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

        }

        // metodo que sera passado como FUNC passando os valores para caixa alta
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}