using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap025
{
    internal class Calculator
    {

        // este método por padrão não daria certo, pois o resultado de x ficaria apenas dentro do método
        // para funcionar é necessário adicionar o ref, tanto no metodo quanto na hora de chamar na main
        public static void Triple(ref int x)
        {
            x = x * 3;
        }


        // neste metodo usando o out, eu indico que eu quero receber um valor de origem, e guardar um valor de saida "out int result"
        public static void Triple2(int origin, out int result)
        {
            result = origin * 3;
        }

    }
}
