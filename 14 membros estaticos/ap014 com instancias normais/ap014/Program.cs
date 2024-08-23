using ap014;
using System;

namespace Program
{

    // no modo de instancias eu devo declarar um objeto calc para fazer seus respectivos metodos
    // neste caso nao e necessario ter instancias pois os valores de qualquer objeto criado serao sempre os mesmos
    // posso criar calc1, calc2, calc3, que as operacoes serao exatamente iguais
    class Program
    {
        static void Main(string[] args)
        {

            Calculadora calc = new Calculadora();

            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());


            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);


            Console.WriteLine("Circunferencia: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F2"));


        }
    }
}