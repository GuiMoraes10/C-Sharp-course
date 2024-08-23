using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------------------\natribuicao");
            //atribuicao
            int n1 = 1;
            n1 += 3;
            Console.WriteLine(n1);
            n1 *= 2;
            Console.WriteLine(n1);
            //tambem funciona com strings
            string s1 = "ABC";
            Console.WriteLine(s1);
            s1 += "DEF";
            Console.WriteLine(s1);

            Console.WriteLine("\natribuicao ++");
            //atribuicao ++
            int n3 = 1;
            int n4 = 1;
            //primeiro ele atribui o n3 ao n4 e depois soma
            int n5 = n3++;
            Console.WriteLine(n5);
            //primeiro ele soma e depois atribui o n3 ao n5
            int n6 = ++n4;
            Console.WriteLine(n6);


            //-------------------------------------------
            Console.WriteLine("------------------------\nconversao");


            // conversao
            // permite converter um float em double
            float f1 = 4.5f;
            double d1 = f1;
            Console.WriteLine(d1);

            // para fazer a conversao inversa que nao e possivel normalmente adiciona se um (tipo de variacel) antes
            double d2 = 4.5;
            float f2 = (float) d2;
            Console.WriteLine(f2);

            // so vou conseguir um resultado em double se indicar antes que o valor dividido sera em double
            int i1 = 5;
            int i2 = 2;
            double resultado = (double)i1 / i2;
            Console.WriteLine(resultado);


            //-------------------------------------------
            Console.WriteLine("------------------------\noperacoes aritmeticas");
            

            //operacoes aritmeticas
            double a = 1.0, b = -3.0, c = -4.0;

            // Math.Pow(atributo, 2.0) faz a potencia do atributo
            double delta = b * b - 4.0 * a * c;
            double delta2 = Math.Pow(b, 2.0) - 4.0 * a * c;

            // deve se colocar entre parenteses para dar prioridade a operacao dentro dele
            // Math.Sqrt(atributo) faz a raiz quadrada do valor
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta2)) / (2.0 * a);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

        }
    }
}