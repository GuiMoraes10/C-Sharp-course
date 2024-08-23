

namespace ATV2.Entities
{
    internal sealed class PessoaJuridica : Pessoa
    {
        public int Nfuncionarios { get; private set; }

        public PessoaJuridica(string nome, double renda, int nfuncionarios) : base(nome, renda)
        {
            Nfuncionarios = nfuncionarios;
        }

        public sealed override double Imposto()
        {
            if(Nfuncionarios > 10)
            {
                return Renda * 0.14;
            }
            else
            {
                return Renda * 0.16;
            }
        }

    }
}
