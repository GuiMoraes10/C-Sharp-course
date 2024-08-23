using System;

namespace ap023_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int tamanho = int.Parse(Console.ReadLine());

            // cria um vetor de objetos produtos
            Produto[] produtos = new Produto[tamanho];


            // percorre o vetor adicionando os objetos a parir de seu construtor
            for (int i = 0; i < tamanho; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                produtos[i] = new Produto(nome, preco);
            }

            double soma = 0.0;

            // percorre o vetor somando os precos de cada objeto que foi adicionado
            for (int i = 0;i < tamanho; i++)
            {
                soma += produtos[i].Preco;
            }

            double media = soma / tamanho;
            Console.WriteLine("PRECO MEDIO = "+ media.ToString("F2"));

        }
    }
}