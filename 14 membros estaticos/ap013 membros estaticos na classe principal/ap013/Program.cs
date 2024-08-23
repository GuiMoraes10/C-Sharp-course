using System;

namespace Program
{
    class Program
    {

        // static faz com que eu nao precise declarar um objeto relacionado a uma funcao ou atributo

        // declaro Pi com o valor de modo estatico para poder chamar ele dentro de outra funcao da classe que tambem e estatica
        static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());


            double circ = Circunferencia(raio);
            double volume = Volume(raio);


            Console.WriteLine("Circunferencia: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2"));


        }

        // crio uma funcao estatica para que eu possa chamar dentro da main que tambem e estatica
        static double Circunferencia (double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume (double raio)
        {
            return (4.0 / 3.0) * Pi * (Math.Pow(raio, 3));
        }

    }
}