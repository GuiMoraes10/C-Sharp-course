using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex001
{
    class ConversorDeMoeda
    {
        
        public static double CalcularValor(double cotacao, double dolares)
        {
            return cotacao * dolares * 1.06;
        }

    }
}
