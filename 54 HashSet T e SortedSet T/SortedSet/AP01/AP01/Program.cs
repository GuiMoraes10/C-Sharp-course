using System;
using System.Collections.Generic;

namespace AP01
{
    class Program
    {
        // HashSet<T> e SortedSet<T>
        // Representam um conjunto de elementos que, não possuem posicao, nao permite repeticoes e com acesso, remocao e insercao repidos
        // HashSet<T> - Armazena em tabela hash, extremamente rapido, a ordem dos elementos nao eh garantida
        // SortedSet - Armazenamento em arvore, rapido, os elementos sao armazenados ordenadamente conforme implementacao IComparer<T>
        // Principais metodos: Add; Clear; Contains; UnionWith(other); IntersectWith(other); ExceptWith(other); Remove(T); RemoveWhere(predicate)
        static void Main(string[] args)
        {
            // por ser um SortedSet, sempre mostrara os elementos ordenados independente da ordem de insercao
            SortedSet<int> a = new SortedSet<int>() { 10, 0, 2, 4, 5, 6, 8 };
            SortedSet<int> b = new SortedSet<int>() { 10, 5, 6, 7, 8, 9 };


            // UNIAO
            // instanciando um novo conjunto e ja inserindo nele todo o conjunto a
            SortedSet<int> c = new SortedSet<int>(a);

            // realiza a uniao de c com b
            c.UnionWith(b);
            PrintCollection(c);


            // INTERSECCAO
            SortedSet<int> d = new SortedSet<int>(a);

            // realiza a interseccao de d com b, retornando os elementos que existem nos dois conjuntos
            d.IntersectWith(b);
            PrintCollection(d);


            // DIFERENCA
            SortedSet<int> e = new SortedSet<int>(a);

            // realiza a diferenca entre e e b, retornando apenas os elementos de a restantes, excluindo dos elementos presentes em b
            e.ExceptWith(b);
            PrintCollection(e);

        }



        // metodo estatico com uma variavel generica que implementa um IEnumerable, que permite utilizar o foreach
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }
}