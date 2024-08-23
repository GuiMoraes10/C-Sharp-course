using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            // estrutura opcional para o if-else quando se deseja decidir um valor com base em uma condição

            //sintaxe
            // (condição) ? caso verdadeiro : caso falso

            double preco = 30.0;
            double desconto = (preco>20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(preco - desconto);

            // funciona igual a um if e else, mas serve apenas quando vai apenas retornar um valor como instrução dentro do if e do else

        }
    }
}