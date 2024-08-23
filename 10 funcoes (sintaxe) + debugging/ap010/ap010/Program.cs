using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {


            // para debugging, devo adicionar um break point na linha
            // aperto f9 onde quero comecar a debugar
            // aperto f5 para rodar
            // aperto f10 para avancar passo a passo pulando um metodo
            // aperto f11 para avancar passo a passo entrando em um metodo
            Console.WriteLine("Digite tres números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());


            //
            int resultado = Maior(n1, n2, n3);
            Console.WriteLine("O maior numero é: " + resultado);
        

            // sintaxe de um metodo com retorno
            static int Maior(int n1, int n2, int n3)
            {
                int m = 0;
                if (n1 > n2 && n1 > n3)
                {
                    m = n1;
                }else if (n2 > n1 && n2 > n3)
                {
                    m = n2;                
                }else if(n3 > n1 && n3 > n2)
                {
                    m = n3;
                }
                return m;
            }
        
        }
    }
}