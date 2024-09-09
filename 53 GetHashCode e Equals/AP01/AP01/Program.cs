using System;
using AP01.Entities;

namespace AP01
{
    class Program
    {
        // GetHashCode e Equals sao utilizadas para comparar se um objeto e igual a outro
        // Equals: lento, mas resposta eh 100%
        // GetHashCode; rapido, mas resposta nao eh 100%
        // Tipos predefinidos como char, string e int ja possuem implementacoes para estas operacoes
        // Classes e structs personalizadas precisam sobrepo-las
        static void Main(string[] args)
        {


            // Equals

            string a = "Maria";
            string b = "Alex";
            Console.WriteLine(a.Equals(b));


            // GetHashCode

            // se o codigo de dois objetos for diferentes, entao os objetos sao diferentes
            // se o codigo de dois objetos for igual, provavelmente sao iguais (pode haver colisao)
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            // para testar um por um, eh recomendado se utilizar o getHashCode, e ai sim utiliza o equals para confirmar, pois ele eh mais rapido


            // EXEMPLO COM O OBJETO DE CLIENT

            Client ca = new Client() { Name = "Maria", Email = "maria@gmail.com" };
            Client cb = new Client() { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(ca.Equals(cb));
            Console.WriteLine(ca.GetHashCode());
            Console.WriteLine(cb.GetHashCode());
        }
    }
}