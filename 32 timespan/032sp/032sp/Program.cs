using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // timespan é parecido com o datetime, porém armazena a duração, e em forma de ticks(100 nanosegundos)


            // (hora, minuto, segundo)
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            // construtores

            TimeSpan a1 = new TimeSpan();
            Console.WriteLine(a1);

            // manda o valor em ticks, o L indica qu é um long
            TimeSpan a2 = new TimeSpan(900000000L);
            Console.WriteLine(a2);

            // (dia, hora, minuto, segundo)
            TimeSpan a3 = new TimeSpan(1, 2, 20, 45);
            Console.WriteLine(a3);

            // (dia, hora, minuto, segundo, milisegundo)
            TimeSpan a4 = new TimeSpan(1, 2, 20, 45, 321);
            Console.WriteLine(a4);


        }
    }
}