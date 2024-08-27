using System;
using System.Runtime.CompilerServices;

namespace AP01
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Fazer um programa para ler o caminho de um arquivo .csv contendo dados de itens vendidos.
            // Cada item possui um nome, preco unitario e quantidade, separados por virgula.
            // Gerar um novo arquivo chamado "summary.csv", localizado em uma subpasta chamada "out"
            // a partir da pasta original do arquivo de origem, contendo o nome e o valor total (preco * quantidade).

            string path = @"C:\temp\folder\SourceFile.csv";
            string newpath = @"C:\temp\folder\summary.csv";

            try
            {
                if (File.Exists(path))
                { 
                    
                    string content = File.ReadAllText(path);

                    string[] lines = content.Split("\n");
                    Produto[] produtos = new Produto[lines.Length-1];

                    int i = 0;
                    foreach (string line in lines)
                    {
                        if (i < lines.Length-1)
                        {
                            string[] values = line.Split(";");
                            string nome = values[0];
                            double preco = double.Parse(values[1]);
                            int quantidade = int.Parse(values[2]);

                            produtos[i] = new Produto(nome, preco, quantidade);
                        }
                        i++;
                    }

                    using (File.Create(newpath)) { }                        

                    using (StreamWriter sr = new StreamWriter(newpath))
                    {
                        foreach (Produto produto in produtos)
                        {
                            sr.WriteLine(produto.ToString());
                        }
                    }

                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}