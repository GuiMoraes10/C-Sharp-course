using EX01.Entities;
using System;
using System.Globalization;
using System.IO;
using System.Reflection.Metadata;

namespace EX01
{
    class Program
    {
        // Um site de internet registra um log de acessos dos usuarios.
        // Um registro de log consiste no nome de usuario e o instante em que
        // o usuario acessou o site no padrao ISO 8601,separados por espaco, conforme exemplo.
        // Fazer um programa que leia o log de acessos a partir de um arquivo,
        // e dai informe quantos usuarios distintos acessam o site        

        static void Main(string[] args)
        {
            string path = @"C:\temp\in.txt";
            HashSet<User> users = new HashSet<User>();

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] lines = line.Split(" ");
                        string Name = lines[0];
                        DateTime Date = DateTime.Parse(lines[1]);
                        users.Add(new User(Name, Date));                        
                    }
                    Console.WriteLine("Total users: " + users.Count);

                }
            }catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}