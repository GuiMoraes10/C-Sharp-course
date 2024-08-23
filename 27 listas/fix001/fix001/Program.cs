using System;

namespace fix001
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos funcionários serão regisrados? ");
            int num = int.Parse(Console.ReadLine());

            // declara uma lista de funcionários
            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Funcionário #" + (i+1) + ":");

                Console.Write("Id: ");
                int id_ = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());

                // adiciona funcionario à lista
                list.Add(new Funcionario( nome, id_,  salario));
            }

            Console.Write("Entre o Id do funcionario que terá o salário aumentado: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Entre a porcentagem: ");
            double valor = double.Parse(Console.ReadLine());

            // encontra o funcionario na lista que tem o id igual ao digitado
            Funcionario func = list.Find(x => x.Id == id);

            func.AumentarSalario(valor);

            foreach (Funcionario funcionario in list)
            {
                Console.WriteLine(funcionario.ToString());
            }

        }
    }
}

    