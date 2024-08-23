using ex001;
using System;

namespace Program
{
    class Program
    {   
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retangulo: ");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = " + r.Area().ToString("F2"));
            Console.WriteLine("PERIMETRO = " + r.Perimetro().ToString("F2"));
            Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2"));

        }
    }
}