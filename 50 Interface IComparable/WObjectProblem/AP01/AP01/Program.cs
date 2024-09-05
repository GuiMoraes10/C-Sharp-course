using AP01.Entities;
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

            string path = @"C:\temp\in2.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    // ordena a lista, mas para ordenar objetos deve implementar a classe IComparable
                    list.Sort();
                    foreach (Employee employe in list)
                    {
                        Console.WriteLine(employe);
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