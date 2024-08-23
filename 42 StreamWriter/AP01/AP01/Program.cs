using System;
using System.IO;

namespace AP01
{
    class Program
    {
        static void Main(string[] args)
        {
            // StreamWriter é capaz de escrever caracteres a partir de uma stream binária

            string path = @"C:\temp\file1.txt";
            string targetpath = @"C:\temp\file2.txt";

            FileInfo fileInfo = new FileInfo(path);

            try
            {
                string[] lines = File.ReadAllLines(path);

                // declarando um StreamWriter
                // append acrescenta ao final do arquivo
                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach (string line in lines)
                    {
                        // Utilizando o StreamWriter para escrever em cada linha
                        sw.WriteLine(line.ToUpper());
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