using System;
using System.Linq;
using Ap01.Entities;

namespace Ap01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Apenas um metodo para facilitar o print dos valores das colecoes (recebe a mensagem que deve ser enviada junto com a colecao apos a query com o LINQ)
            static void Print<T>(string message, IEnumerable<T> collection)
            {
                Console.WriteLine(message);
                foreach (T obj in collection)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine();
            }

            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 },
            };

            // Query para pegar apenas os valores que sao de categoria 1 e preco menor que 900
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("TIER 1 AND PRICE < 900:", r1);

            // Query para pegar apenas os valores que pertencem a categoria Tools, e salvando na colecao apenas os nomes
            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAME OF PRODUCTS FROMS TOOLS", r2);

            // Query para pegar apenas os valores que comecam com o C no nome, e salvando na colecao o nome, preco e nome da categoria
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name }); // Por conta de ter 2 valores Name, e necessario
            Print("NAME STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);                                                             // dar um apelido ao p.Category.Name como o mostrado

            // Query para pegar os produtos com categoria tier 1, ordenando por preco e quando for igual, ordena por nome
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            // Query para pegar o resultado da query do r4, pula os 2 primeiros elementos e pega os proximos 4
            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            // Query para pegar o primeiro valor da lista,o e caso não tenha, aceita e nao retorna nada
            var r6 = products.First();
            Console.WriteLine("First or default test1: " + r6);
            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);
            Console.WriteLine();

            // Query que retorna apenas um valor e utiliza o SingleOrDefault, para indicar que eu quero apenas um valor ou nada como resultado
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault(); // SingleOrDefault() funciona apenas se o where der um resultado ou menos
            Console.WriteLine("Single or default test1: " + r8);       // SingleOrDefault() transforma o IEnumerable em um valor, assim como o FirstOrDefault()
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);
            Console.WriteLine();

            // Query para receber o valor maximo e minimo de preco da lista
            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);

            // Query para somar os precos de todos os produtos da categoria 1
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);
            // Query para fazer a media os precos de todos os produtos da categoria 1
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);

            // Query que retornaria um erro por tentar calcular a media de um valor vazio, porem nao da erro por conta do DefaultIfEmpty()
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty().Average();
            Console.WriteLine("Category 5 Average prices: " + r14);

            // Query para fazer operacoes personalizadas
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y); // Aggregate((x, y) => x + y) indica uma operacao personalizada atraves de
            Console.WriteLine("Category 1 aggregate sum: " + r15);                                             // uma funcao anonima, nela eu vou receber dois valores, e somá-los

            // Query para fazer operacoes personalizadas, porem com o valor default para nao retornar um erro quando o select nao tiver nenhum valor
            var r16 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 5 aggregate sum: " + r16);
            Console.WriteLine();

            // Query para agrupar os produtos por categoria
            var r17 = products.GroupBy(p => p.Category);
            // Por retornar um IGrouping, para imprimir deve se fazer os seguintes foreach
            // Primeiro busca por cada categoria
            foreach(IGrouping<Category, Product> group in r17)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                // Em seguida busca por cada produto dentro desta categoria
                foreach(Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}