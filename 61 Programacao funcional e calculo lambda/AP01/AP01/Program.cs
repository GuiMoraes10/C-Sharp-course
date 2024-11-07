using System;

namespace AP01
{
    class Program
    {
        // Programação funcional e cálculo lambda
        static void Main(string[] args)
        {

            // C# não é simplesmente uma linguagem orientada a objetos e sim uma linguagem multiparadigma,
            // pois também possui caracteristicas de programação funcional

            // forma imperativa - mais escrita
            List<int> list = new List<int>();
            int sum1 = 0;
            foreach (int x in list)
            {
                sum1 += x;
            }

            // forma funcional - menos escrita
            // agrega todo mundo da lista comecando com 0 e fazendo a operacao de soma em cada um deles
            int sum2 = list.Aggregate(0, (x, y) => x + y);

        }
    }
}