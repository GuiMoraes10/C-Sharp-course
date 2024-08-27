using System;
using System.IO;

namespace AP01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path - Realiza operacoes com strings que contem informacoes de arquivos ou pastas

            string path = @"C:\temp\myfolder\file1.txt";

            // retorna o string da pasta do arquivo
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));

            // retorna qual e o caractere de separacao entre os diretorios e arquivos
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            
            // retorna qual e o caractere utilizado para separar entre paths diferentes
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            
            // retorna o nome do arquivo do caminho
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            
            // retorna o nome do arquivo do caminho sem a extensao .txt
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));

            // retorna somente a extensao do arquivo do caminho
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            
            // retorna o caminho completo do arquivo
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            
            // retorna qual e a pasta temporaria do sistema
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());

        }
    }
}