using ap015;
using System;

namespace Program
{

    
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());


            // deste modo chamo apenas o nome da classe em vez de declarar um objeto
            // isso por conta dela conter apenas membros estaticos
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);


            Console.WriteLine("Circunferencia: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2"));


        }
    }
}