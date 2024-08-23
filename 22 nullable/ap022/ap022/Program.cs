using System;

namespace ap022
{
    class Program
    {
        static void Main(string[] args)
        {

            // o Nullable serve para que eu possa transformar valores que não podem ser nulos em nulos


            // isto não pode ser feito
            //double x = null;


            // declaramos assim para o valor ser nulo
            //Nullable<double> x = null;


            // a mesma coisa mas de uma forma mais simples
            double? x = null;
            double? y = 10.0;


            // este metodo pega ou o valor que esta no atributo, ou o padrão que neste caso é 0
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());


            // imprime um booleano indicando se o atributo tem ou não valor
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);


            // neste caso, quebraria o codigo, pois o x é nulo, então deve se colocar um if  
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }else
                Console.WriteLine("X é nulo");

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
                Console.WriteLine("Y é nulo");


            // neste caso ele diz que o y tem o valor de x, mas caso o x seja nulo o valor será 0.0
            y = x ?? 0.0;
            Console.WriteLine(y);

        }
    }
}