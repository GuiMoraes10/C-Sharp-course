using System;
using System.Numerics;

namespace ap023
{
    class Program
    {
        static void Main(string[] args)
        {
            // vetores struct

            int tamanho = int.Parse(Console.ReadLine());
            
            // declarando um vetor de double com o tamanho especificado
            double[] vetor = new double[tamanho];

            // percorre o vetor adicionando valores a cada posição
            for (int i = 0; i<tamanho; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine());
            }

            double soma = 0;

            // percorre o vetor somando todos os valores para depois calcular a média
            for (int i = 0;i<tamanho; i++)
            {
                soma += vetor[i];
            }

            double media = soma / tamanho;
            Console.WriteLine("MÉDIA: " + media.ToString("2F"));
        }
    }
}