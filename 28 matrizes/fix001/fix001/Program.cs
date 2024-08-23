using System;

namespace fix001
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o tamanho da matriz: ");
            int n = int.Parse(Console.ReadLine());

            // declaro a matriz de int
            int[, ] matriz = new int[n , n];

            Console.WriteLine("Digite os valores");

            // for dentro do for para percorrer todos os pontos da matriz
            for (int i = 0; i < n; i++)
            {

                // vetor de string salvando os valores de uma linha inteira e separando por um espaço
                string[] valores = Console.ReadLine().Split(' ');
                
                for ( int j = 0; j < n; j++)
                {
                    // dentro do j, por ja ter digitado os 3 valores da linha no vetor
                    // apenas transforma em int adiciona esses valores na posição i e j da matriz
                    matriz[i, j] = int.Parse(valores[j]);

                }
            }

            Console.WriteLine("Diagonal princial");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i == j)
                    {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }

            int negativos = 0;
            Console.WriteLine("Quantidade de negativos");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        negativos++;
                    }
                }
            }
            Console.WriteLine(negativos);





        }
    }
}