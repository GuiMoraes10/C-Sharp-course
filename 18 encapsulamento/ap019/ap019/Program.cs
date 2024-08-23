using System;
using ap019;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetValor());
            Console.WriteLine(p.GetQuantidade());

        }
    }
}


