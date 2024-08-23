using System;

namespace ap028
{
    class Program
    {
        static void Main(string[] args)
        {

            // intanciando uma matriz com duas linhas e tres colunas
            double[,] matriz = new double[2, 3];


            // imprime quantos elementos a matriz tem no total
            Console.WriteLine(matriz.Length);

            
            // imprime quantas linhas tem na matriz
            Console.WriteLine(matriz.Rank);


            // imprime que a dimensão 0 da matriz tem tamanho 2, que é a quantidade de linhas da matriz
            Console.WriteLine(matriz.GetLength(0));


            // imprime que a dimensão 1 da matriz tem tamanho 3, que é a quantidade de colunas da matriz
            Console.WriteLine(matriz.GetLength(1));

        }
    }
}

    