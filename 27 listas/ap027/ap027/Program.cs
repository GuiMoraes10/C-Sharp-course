using System;

// tem que adicionar este using para utilizar
using System.Collections.Generic;

namespace ap027
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ADICIONANDO VALORES: \n");


            // diferente do vetor, a lista já começa vazia, e vai aumentando conforme vou adicionando valores
            List<string> list = new List<string>();


            // adicionar valores por valor apenas
            list.Add("Guilherme");
            list.Add("Lucas");
            list.Add("Marco");
            list.Add("Nome");
            list.Add("Alex");
            list.Add("Ana");


            // adicionar valores por valor e posição
            // desa forma, caso ja tenha um valor, ele "empurra" este valor para uma linha a frente
            list.Insert(2, "Fernando");

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----------------");


            // imprime o tamanho da lista
            Console.WriteLine(list.Count);

            // salva na string o nome do primeiro valor que começar com o valor A
            // salva na string o valor que bate com uma função booleana
            // este x=>... indica uma função de x onde, caso na posição 0 o x == 'A'
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);


            // salva na string o nome do ultimo valor que começar com o valor A
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);


            // salva o int da primeira posição em que o valor satisfaça uma função string x[0]=='A'
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);


            // salva o int da ultima posição em que o valor satisfaça uma função string x[0]=='A'
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);


            // encontra todos os valores que satisfaçam a função e salva em uma lista
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string s in list2)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----------------");



            Console.WriteLine("\n\nREMOVENDO VALORES: \n");

            // remover valores por valor
            list.Remove("Guilherme");
            foreach(string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----------------");


            // remove todos os valores que começam com a letra M
            list.RemoveAll(x => x[0] == 'M');
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----------------");


            // remove um valor por posição
            list.RemoveAt(2);
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----------------");


            // remove um valor por um range/ uma área
            // remove a partir do valor de index 0, e remove 2 elementos
            list.RemoveRange(0, 2);
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("----------------");

        }
    }
}