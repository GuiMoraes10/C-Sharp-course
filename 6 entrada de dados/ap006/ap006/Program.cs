using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // lendo entradas do teclado
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();


            // imprimindo as entradas
            Console.WriteLine("voce digitou:");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            
            // lendo cada string ate o espaco
            string s = Console.ReadLine();
            // declara um vetor de string que recebe a variavel da frase e a divide a cada caractere vazio ' '
            // armazenando cada uma dessas partes em um vetor de string
            string[] vet = s.Split(' ');
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);


            // faz a mesma coisa mas direto no readline
            string[] vet2 = Console.ReadLine().Split(' ');
            Console.WriteLine(vet2[0]);
            Console.WriteLine(vet2[1]);
            Console.WriteLine(vet2[2]);



        }
    }
}