using System;
using System.IO;

namespace AP01
{
    class Program
    {
        static void Main(string[] args)
        {

            // FileStream - Disponibiliza stream associada a um arquivo permitindo leitora e escrita com dados binários
            // StreamReader - Capaz de ler caracteres a partir de uma stream binária (ex: FileStream)

            string path = @"C:\temp\file1.txt";
            FileStream? fs = null;
            StreamReader? sr = null;

            try
            {
                // instancia o FileStream passando o caminho do arquivo e o modo como será instanciado - FoleMode.Open para abrir
                fs = new FileStream(path, FileMode.Open);
                // o StreamReader recebe um FileStream como argumento
                sr = new StreamReader(fs);

                // enquanto não chegar ao fim do arquivo
                while (!sr.EndOfStream)
                {
                    // lê uma linha do arquivo e armazena
                    string? line = sr.ReadLine();
                    Console.WriteLine(line);
                }

                // ************* MODO "SIMPLIFICADO" *************               

                FileInfo fi = new FileInfo(path);
                StreamReader sr2 = fi.OpenText();

                // enquanto não chegar ao fim do arquivo
                while (!sr2.EndOfStream)
                {
                    // lê uma linha do arquivo e armazena
                    string? line = sr2.ReadLine();
                    Console.WriteLine(line);
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            finally // necessário para fechar as streams manualmente, pois elas são externas ao .NET
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }

        }
    }
}