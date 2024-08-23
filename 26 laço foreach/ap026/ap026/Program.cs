using System;

namespace ap026
{
    class Program
    {
        static void Main(string[] args)
        {
            // o laço foreach é uma forma simplificada de percorrer coleções/vetores


            int[] vetor = new int[] { 1, 2, 3 };


            // desta forma, eu indico que para cada int numero dentro do vetor eu imprimo no console
            foreach(int numero in vetor)
            {
                Console.WriteLine(numero);
            }
        }
    }
}