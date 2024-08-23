using System;
using System.Linq.Expressions;


namespace AP01
{
    class Program
    {
        static void Main(string[] args)
        {
            // using block é uma sintaxe simplificada que garante que objentos IDisposable serão fechados(ex: FileStream e StreamReader)


            string path = @"C:\temp\file1.txt";

            try
            {


                // ao final desse bloco tudo que foi passado será automaticamente fechado
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    // pode ser cascateado
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }

                // MODO SIMPLIFICADO
                FileInfo fi = new FileInfo(path);

                using (StreamReader sr2 = fi.OpenText())
                {
                    while (!sr2.EndOfStream)
                    {
                        string line = sr2.ReadLine();
                        Console.WriteLine(line);
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