

namespace ATV2.Entities
{
    internal sealed class PessoaFisica : Pessoa
    {
        public double GastosSaude { get; private set; }

        public PessoaFisica(string nome, double renda, double gastosSaude) : base(nome, renda)
        {
            GastosSaude = gastosSaude;
        }

        public sealed override double Imposto()
        {
            if (Renda < 20000)
            {
                if(GastosSaude > 0)
                {
                    return (Renda * 0.15) - (GastosSaude / 2);
                }
                else
                {
                    return Renda * 0.15;
                }
                
            }
            else
            {
                if (GastosSaude > 0)
                {
                    return (Renda * 0.25) - (GastosSaude / 2);
                }
                else
                {
                    return Renda * 0.25;
                }
            }
        }

    }
}
