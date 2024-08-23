using System;

namespace ap025
{
    class Program
    {
        static void Main(string[] args)
        {

            // ambos são considerados disgns ruins e devem ser evitados

            int a = 10;

            // usando o ref eu indico que o resultado do metodo sera guardado no valor de a como referencia
            // o ref, necessita de que seja declarado um valor para a variavel que entrara como parametro
            Calculator.Triple(ref a);
            Console.WriteLine(a);


            int b = 10;
            int triplo;
            
            // desta forma, usando o out, eu indico o valor que sera a entrada, e um valor (triple no caso) que será guardado como saida
            Calculator.Triple2(b, out  triplo);
            Console.WriteLine(triplo);

            // ambos fazem a mesma coisa, mas ref é uma forma de fazer o usuario iniciar a variavel
        }
    }
}