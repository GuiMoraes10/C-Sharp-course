using System;

namespace AP01
{
    // Dictionary e SortedDictionary
    //
    // Dictionary - Colecao de pares chave / valor - Dictionary<Tkey, TValue>
    // Nao admite repeticoes do objeto chave
    // Os elementos sao indexados pelo objeto chave (nao possuem posicao)
    // Acesso, insercao e remocao de elementos sao rapidos
    // Uso comum: cookies, local storage e qualquer modelo chave e valor
    //
    // Diferencas
    //
    // Dictionary
    // Armazenamento em tabela hash
    // Extremamente rapido
    // Ordem dos elementos nao eh garantida
    //
    // SortedDictionary
    // Armazenamento em arvore
    // Rapido
    // Os elementos sao armazenados ordenadamente conforme implementacao IComparer<T>
    class Program
    {
        static void Main(string[] args)
        {

            // Implementa o passando o tipo da chave (string) e o tipo do valor (string)
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            // Adiciono o valor maria a chave user
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";

            // Neste caso, como o Dictionary nao aceita repeticoes, ira sobrescrever o primeiro valor inserido
            cookies["phone"] = "99712234";
            cookies["phone"] = "83737388";

            // Imprime o valor da chave phone
            Console.WriteLine(cookies["phone"]);
            Console.WriteLine(cookies["email"]);

            // Remove a chave email
            cookies.Remove("email");

            // Verifica se possui a chave email
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            // Imprime o tamanho do Dictionary
            Console.WriteLine("Size: " + cookies.Count);

            // Imprimindo todos os valores, indicando que para cada par de string string, ira imprimir
            Console.WriteLine("ALL COOKIES:");
            // pode ser usado apenas o var no lugar de KeyValuePair<string, string>
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}