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

            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }

        }
    }
}