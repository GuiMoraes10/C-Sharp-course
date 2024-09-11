using System;
using System.Collections.Generic;

namespace EX02
{
    class Program
    {
        // Em um portal de cursos online, cada usuario possui um codigo unico, representado por um numero inteiro.
        //
        // Cada instrutor do portal pode ter varios cursos, sendo que um mesmo aluno pode se matricular em quantos cursos quiser.
        // Assim, o numero total de alunos de um instrutor nao e simplesmente a soma dos alunos de todos os cursos que ele possui,
        // pois pode haver alunos repetidos de mais de um curso
        //
        // O instrutor Alex possui tres cursos A, B e C, e deseja saber o numero total de alunos.
        //
        // Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar a quantidade total de alunos dele.

        static void Main(string[] args)
        {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            try
            {
                Console.Write("How many students for course A? ");
                int nA = int.Parse(Console.ReadLine());
                for (int i = 0; i < nA; i++)
                {
                    A.Add(int.Parse(Console.ReadLine()));
                }

                Console.Write("How many students for course B? ");
                int nB = int.Parse(Console.ReadLine());
                for (int i = 0; i < nB; i++)
                {
                    B.Add(int.Parse(Console.ReadLine()));
                }

                Console.Write("How many students for course C? ");
                int nC = int.Parse(Console.ReadLine());
                for (int i = 0; i < nC; i++)
                {
                    C.Add(int.Parse(Console.ReadLine()));
                }

                HashSet<int> students = new HashSet<int>();
                students.UnionWith(A);
                students.UnionWith(B);
                students.UnionWith(C);

                Console.WriteLine("Total students: " + students.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}