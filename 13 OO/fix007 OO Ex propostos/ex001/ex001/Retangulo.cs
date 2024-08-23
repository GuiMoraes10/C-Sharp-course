using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex001
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return (Altura * 2) + (Largura * 2);
        }

        public double Diagonal()
        {
            double c = (Altura * Altura) + (Largura * Largura);
            double diagonal = Math.Sqrt(c);
            return diagonal;
        }

    }
}
