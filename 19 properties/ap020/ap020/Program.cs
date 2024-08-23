using ap020;
using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);

            // agora na hora de setar um valor e receber, eu apenas digito objeto.nomeDoAtributo
            p.Nome = "TV 4K";
            Console.WriteLine(p.Nome);


            Console.WriteLine(p.Valor);
            Console.WriteLine(p.Quantidade);

        }
    }
}


