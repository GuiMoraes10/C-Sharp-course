using System;

namespace AP01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Realizam operações com pastars(create, enumerate, get files, etc.)
            // Directory - Estatico, mais lenta
            // DirectoryInfo - Instanciado, mais rápido

            string path = @"C:\temp\myfolder";

            try
            {
                // enumera os diretorios no caminho selecionado, o *.* é o padrão de busca que significa que vai buscar por qualquer arquivo . qualquer extensao,
                // o ultimo e a opcao de busca, SearchOption.AllDirectories passa que buscara ate mesmo as subpastas
                var folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folder)
                {
                    Console.WriteLine(s);
                }

                // enumera os arquivos no caminho selecionado, o *.* é o padrão de busca que significa que vai buscar por qualquer arquivo . qualquer extensao,
                // o ultimo e a opcao de busca, SearchOption.AllDirectories passa que buscara ate mesmo as subpastas
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                // criar uma nova pasta
                Directory.CreateDirectory(path + @"\newfolder");

                Directory.CreateDirectory(path + @"C:\temp\myfolder\newfolder2");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}