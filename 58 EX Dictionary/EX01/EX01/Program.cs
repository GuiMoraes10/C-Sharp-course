using System;

namespace EX01
{
    class Program
    {
        // Na contagem de votos de uma eleicao, sao gerados varios registros de votacao contenco o nome do candidato e a quantidade de votos que obteve.
        // Voce deve fazer umm programa para ler os registros de votacao a partir de um arquivo, e dai gerar um relatorio consolidado com os totais de cada candidato.
        static void Main(string[] args)
        {
            string path = @"C:\temp\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string Name = line[0];
                        int Number = int.Parse(line[1]);

                        if (dictionary.ContainsKey(Name))
                        {
                            dictionary[Name] += Number;
                        }
                        else
                        {
                            dictionary[Name] = Number;
                        }
                    }

                    foreach (var item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}