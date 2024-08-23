
using Atividade.Entities;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de funcionários a serem consultados: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> lista = new List<Employee>();
            

            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine("Funcionário " + i);
                Console.Write("O funcionário é terceirizado? (responda com 'Sim' ou 'Nao'): ");
                string response = Console.ReadLine();

                if(response == "Sim")
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Horas: ");
                    int horas = int.Parse(Console.ReadLine());
                    Console.Write("Valor por hora: ");
                    double valorPorHora = double.Parse(Console.ReadLine());
                    Console.Write("Custo adicional: ");
                    double custoAdicional = double.Parse(Console.ReadLine());

                    Employee employee = new OutsourceEmployee(custoAdicional, nome, horas, valorPorHora);
                    lista.Add(employee);
                }
                else if(response == "Nao")
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Horas: ");
                    int horas = int.Parse(Console.ReadLine());
                    Console.Write("Valor por hora: ");
                    double valorPorHora = double.Parse(Console.ReadLine());

                    Employee employee = new Employee(nome, horas, valorPorHora);
                    lista.Add(employee);
                }
                else
                {
                    Console.WriteLine("Responda apenas com Sim e Nao, funcionário não adicionado");
                }
            }


            foreach(Employee emp in lista)
            {
                Console.WriteLine("\n\nNome: " + emp.Name + "\nPagamento: " + emp.Payment());
            }

        }
    }
}