using System;
using System.Drawing;
using AP01.Entities;
using AP01.Enums;

namespace AP01
{
    class Program
    {

        // Implementando uma classe como interface, mas também definir uma estrutura comum reutilizavel presente em uma superclasse de herança
        // Implementação que combina interface com classe abstrata
        // Isto é feito criando uma interface Shape com o método Area e cumprindo o contrato dela uma classe abstrata AbstractShape com o atributo Color
        // As demais classes irão herdar da classe abstrata
        // Isto garante reuso e cumprimento de contrato e garante que por mais que toda figura tenha uma Area, nem toda tem o atributo de cor

        static void Main(string[] args)
        {

            IShape s1 = new Circle() { Radius = 2, Color = Enums.Color.White };
            IShape s2 = new Entities.Rectangle() { Width = 3.5, Height = 4.2, Color = Enums.Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}