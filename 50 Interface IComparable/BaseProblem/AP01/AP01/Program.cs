using System;
using System.Numerics;

namespace AP01
{
    class Program
    {

        // interface IComparable serve para comparar um objeto com outro
        // diz se um é maior, menor ou igual ao outro

        static void Main(string[] args)
        {

            string path = @"C:\temp\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    // ordena a lista
                    list.Sort();
                    foreach (string str in list)
                    {
                        Console.WriteLine(str);
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