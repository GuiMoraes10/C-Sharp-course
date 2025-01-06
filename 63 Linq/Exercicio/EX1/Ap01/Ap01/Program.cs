using Ap01.Entities;
using System.Globalization;

namespace Ap01
{
    class Program
    {
        // ler um conjunto de produtos a partir de um .csv
        // em seguida mostrar o preco medio dos pordutos. depois mostrar os nomes, em ordem decrescente, dos produtos que possuem preco inferior ao preco medio

        // Input:
        //
        // Tv, 900.00
        // Mouse, 50.00
        // Tablet, 350.00
        // HD Case, 80.90
        // Computer, 850.00
        // Monitor, 290.00

        //Execution:
        //
        // Enter full file path: c:/temp/in.txt
        // Average price: 420.23
        // Tablet
        // Mouse
        // Monitor
        // HD Case

        static void Main(string[] args)
        {

            List<Product> list = new();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            try
            {
                FileInfo file = new FileInfo(path);

                if (file.Exists)
                {
                    using (StreamReader sr = file.OpenText())
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] line = sr.ReadLine().Split(',');
                            list.Add(new Product(line[0], double.Parse(line[1], CultureInfo.InvariantCulture)));
                        }
                    }

                    double averagePrice = list.Average(p => p.Price);
                    Console.WriteLine("Average price: " + averagePrice.ToString("F2", CultureInfo.InvariantCulture));

                    var r = list.Where(p => p.Price < averagePrice).Select(p => p.Name).OrderDescending();
                    foreach(string name in r)
                    {
                        Console.WriteLine(name);
                    }
                }
                else
                {
                    Console.WriteLine("File not found");
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}