using System;
using System.Globalization;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // o console le apenas em formato de string
            // entao eu devo converter string em int
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("voce digitou:" + n1);

            //convertendo para char
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("voce digitou: " + ch);

            //convertendo double
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("voce digitou: " + d);
            //posso alterar para usar o . em vez da ,
            //double d2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            // crio um vetor de string que vai ler as entradas do teclado e separar cada caractere vazio (' ')
            string[] vet = Console.ReadLine().Split(' ');
            // adiciono cada valor ao vetor com o parse para cada valor para que as strings recebidas sejam transformadas em outros tipos de atributos
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);
            Console.WriteLine("voce digitou: " + nome + ", " + sexo + ", " + idade + ", " + altura);

        }
    }
}