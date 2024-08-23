using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            string original = "abcde FGHIJ ABC abc DEFG    ";


            // transoforma todos os caracteres em maiusculo
            string s1 = original.ToUpper();
            Console.WriteLine("original: -"+original+"-");
            Console.WriteLine("maiuscula: -"+s1+"-");

            // transoforma todos os caracteres em minusculo
            string s2 = original.ToLower();
            Console.WriteLine("minuscula: -" + s2 + "-");

            // apaga os espacos em branco entre as palavras
            string s3 = original.Trim();
            Console.WriteLine("trim: -"+s3+"-");

            // permite pegar apenas uma parte da string
            // nesse caso corta a string a partir da posição 3
            string s4 = original.Substring(3);
            Console.WriteLine(s4);
            // nesse caso corta a tring a partir da posição 3 e pega 5 caracteres
            string s5 = original.Substring(3, 5);
            Console.WriteLine(s5);

            // substitui um caractere ou uma string por outro valor
            // neste caso substitui 'a' por 'x'
            string s6 = original.Replace('a', 'x');
            Console.WriteLine("replace: -"+s6+"-");

            // neste caso substitui por string, neste caso abc por xyz
            string s7 = original.Replace("abc", "xyz");
            Console.WriteLine("replace -"+s7+"-");

            // testar se a string é vazia
            bool b1 = String.IsNullOrEmpty(original);
            Console.WriteLine(b1);

            // verifica se a string é nula ou um monte de espaço em branco
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine(b2);

        }
    }
}