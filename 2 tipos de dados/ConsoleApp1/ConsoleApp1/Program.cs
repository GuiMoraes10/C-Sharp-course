using System;

namespace Program
{
    class Program
    {
        static void Main(String[] args)
        {


            int x = 100;
            Console.WriteLine(x);
            // int e long - inteiros
            // float e double - decimais 
            // char caractere
            // bool booleano

            // para float tem que colocar o f na frente se não ele reconhece como double
            float n = 1.5f;
            double n1 = 4.5;
            Console.WriteLine(n);
            Console.WriteLine(n1);

            // string
            string nome = "Guilherme";
            Console.WriteLine(nome);

            // é um objeto generico que pode receber qualquer coisa
            object obj1 = "Guilherme";
            Console.WriteLine(obj1);

            // indica o valor minimo e máximo de cada variavel
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(decimal.MaxValue);
            
        }
    }
}
// cw + tab, tab digita console.writeline sozinho
