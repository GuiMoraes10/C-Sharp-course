using System;
using System.Globalization;
using System.IO;

namespace AP01
{
    class Program
    {
        public static void Main(string[] args)
        {
            // As duas operações fazem as mesmas coisa, porem com caracteristicas diferentes
            // File - mais simples, porém mais lenta pois realiza verificações de segurança todas as vezes em que é chamada
            // FileInfo - precisa ser instanciado, porém não possui verificações de segurança, sendo mais rápida

            //IOException - excessões possíveis que podem ocorrer quando se trabalha com arquivos

            string sourcePath = @"C:\temp\file1.txt";
            string targetPath = @"C:\temp\file2.txt";

            try
            {
                // exemplo fileinfo
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                // exemplo de file
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            } // mostra a mensagem de erro relacionada aos arquivos           
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}