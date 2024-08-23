using System;

namespace ap024
{
    class Program
    {
        static void Main(string[] args)
        {

            // declaro um resultado ja com os valores do vetor instanciados
            // existe uma forma melhor de fazer isso, usando o params
            int resultado = Calculator.Sum(new int[] { 1, 2, 3, 4, 5, });
            Console.WriteLine(resultado);


            // por ter o params no metodo, eu posso colocar a quantidade de parametros que quiser no metodo
            // faz a mesma coisa que o resultado 1 mas de uma maneira melhor
            int resultado2 = Calculator.Sum(1, 2, 3, 4, 5);
            Console.WriteLine(resultado2);

        }
    }
}