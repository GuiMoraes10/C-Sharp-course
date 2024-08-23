using ex002;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite as tres notas do aluno: ");
            a.N1 = double.Parse(Console.ReadLine());
            a.N2 = double.Parse(Console.ReadLine());
            a.N3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2"));
            Console.WriteLine(a.Aprovado());

        }
    }
}