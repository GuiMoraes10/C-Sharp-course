using Ap01.Entities;
using System.Globalization;

namespace Ap01
{
    class Program
    {
        // Fazer um programa para ler os dados (nome, email e salario)
        // de funcionarios a partir de um arquivo txt
        //
        // Em seguida mostrar, em ordem alfabetica, o email dos
        // funcionarios cujo salario seja superior a um dado valor
        // fornecido pelo usuario
        //
        // Mostrar tambem a soma dos salarios dos funcionarios cujo nome comeca com a letra 'M'

        // Input file:
        // Maria,maria@gmail.com,3200.00
        // Alex,alex@gmail.com,1900.00
        // Marco,marco@gmail.com,1700.00
        // Bob,bob@gmail.com,3500.00
        // Anna,anna@gmail.com,2800.00
        //
        // Execution:
        // Enter full file path: c:\temp\in.txt
        // Enter salary: 2000.00
        // Email of people whose salary is more then 2000.00:
        // anna@gmail.com
        // bob@gmail.com
        // maria@gmail.com
        // Sum of salary of people whose name starts with 'M': 4900.00

        static void Main(string[] args)
        {
            //C:\Users\moraes\Documents\Estd\C#\63 Linq\Exercicio\EX2\in.txt

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double RefSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                List<Employee> employees = new List<Employee>();

                FileInfo file = new FileInfo(path);

                if (file.Exists)
                {
                    using (StreamReader sr = file.OpenText())
                    {
                        while (!sr.EndOfStream)
                        {
                            string []line = sr.ReadLine().Split(',');
                            string name = line[0];
                            string email = line[1];
                            double salary = double.Parse (line[2], CultureInfo.InvariantCulture);

                            employees.Add(new Employee(name, email, salary));
                        }
                    }

                    var r = employees.Where(e => e.Salary > RefSalary).Select(e => e.Email);

                    Console.WriteLine("Email of people whose salary is more then " + RefSalary.ToString("F2", CultureInfo.InvariantCulture) + ":");
                    foreach (string email in r)
                    {
                        Console.WriteLine(email);
                    }

                    var r2 = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);

                    Console.Write("Sum of salary of people whose name starts with 'M': ");
                    Console.WriteLine(r2.ToString("F2", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("File not found");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}