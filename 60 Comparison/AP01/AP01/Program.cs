using AP01.Entities;
using System;
using System.Security.Cryptography;

namespace AP01
{
    class Program
    {
        // Comparison<T>
        // Parecido com o IComparable, porem no IComparable a classe não fica fechada para alteracao e
        // se o criterio de comparacao mudar, é necessario alterar a classe product.
        // Podemos entao usar a sobrecarga do metodo "Sort" da classe List:
        // public void Sort(Comparison<T> comparison)
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            // implementacao
            // indico que a comparacao sera feita com base no metodo estatico de comparacao criado (referência/delegate)

            // Posso tanto referenciar diretamente o metodo
            //list.Sort(CompareProducts);

            // Posso salvar o metodo em uma variavel Comparison<T>
            //Comparison<Product> comp = CompareProducts;
            //list.Sort(comp);

            // Tambem posso implementar sem o metodo e utilizando uma funcao lambda anônima
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            list.Sort(comp);
            
            // também funciona da seguinte forma
            //list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        // Metodo que fara o mesmo processo da comparacao IComparable
        //static int CompareProducts(Product p1, Product p2)
        //{
        //    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        //}

    }
}