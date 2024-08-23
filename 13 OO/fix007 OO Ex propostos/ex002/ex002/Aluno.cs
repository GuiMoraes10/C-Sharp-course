using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex002
{
    internal class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }

        public string Aprovado()
        {
            if (NotaFinal() >= 60)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO\nFALTARAM " + Falta().ToString("F2") + " PONTOS";
            }
        }

        public double Falta()
        {
            return 60 - NotaFinal();
        }


    }
}
