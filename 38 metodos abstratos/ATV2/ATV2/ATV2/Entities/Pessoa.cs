using System.Reflection.Metadata.Ecma335;

namespace ATV2.Entities
{
    public abstract class Pessoa
    {
        public string Nome { get; private set; }
        public double Renda { get; private set; }

        public Pessoa(string nome, double renda)
        {
            Nome = nome;
            Renda = renda;
        }

        public abstract double Imposto();

    }
}
