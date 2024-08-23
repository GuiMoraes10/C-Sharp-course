using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fix001
{
    public class Funcionario
    {
        public string Nome {  get; set; }
        public int Id { get; set; }
        public double Salario { get; private set; }

        public Funcionario(string nome, int id, double salario)
        {
            Nome = nome;
            Id = id;
            Salario = salario;
        }

        public void AumentarSalario(double valor)
        {
            Salario += Salario * valor / 100;
        }

        public override string ToString()
        {
            return "Lista atualizada de funcionarios: \n" + Id + ", " + Nome + ", " + Salario.ToString("F2");
        }
    }
}
