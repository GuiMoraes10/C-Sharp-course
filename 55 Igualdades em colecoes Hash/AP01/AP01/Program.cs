using System;
using System.Collections.Generic;
using AP01.Entities;

namespace AP01
{
    class Program
    {
        // Como coleções Hash testam igualdade?

        // Se GetHashCode e Equals estiverem implementados:
        // Primeiro GetHashCode. Se der igual, usa Equals para confirmar

        // Se GetHashCode e Equals nao estiverem implementados:
        // Tipos referencia: compara as referencias dos objetos
        // Tipos valor: compara os valores dos atributos
        static void Main(string[] args)
        {
            
            HashSet<string> set = new HashSet<string>();

            set.Add("Maria");
            set.Add("Alex");

            // Se GetHashCode e Equals estiverem implementados:
            // este contains compara com o GetHashCode, e caso seja igual utiliza o Equals para confirmar
            Console.WriteLine(set.Contains("Maria"));



            // Se GetHashCode e Equals nao estiverem implementados:

            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3 , 4));
            b.Add(new Point(5 , 10));

            // apesar de ter os mesmos valores do produto notebook adicionado ao HashSet, é um objeto diferente com enderecos de memoria diferentes
            Product prod = new Product("Notebook", 1200.0);
            // retornara falso por se tratar de um tipo referencia, pois ele compara os enderecos de memoria, que sao diferentes
            Console.WriteLine(a.Contains(prod));


            // retornara true por se tratar de um tipo valor, pois ele compara os valores dos atributos, que sao iguais
            Point p = new Point(5 , 10);
            Console.WriteLine(b.Contains(p));

        }
    }
}