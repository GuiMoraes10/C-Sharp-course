using ap01.Services;

// MULTICAST DELEGATES

// são delegates que guardam referencia para mais de um metodo
// para adicionar a referencia, utiliza-se o operador +=
// seu uso faz sentido em metodos void

namespace Ap01
{

    delegate void BinaryNumericOperation(double n1,  double n2);

    class Program
    {


        static void Main(string[] args)
        {

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;

            // adiciono tambem a referencia para a outra funcao
            op += CalculationService.ShowMax;

            // chama os metodos
            // (sempre serao executados na ordem em que foram adicionados)
            op(a, b);

        }
    }
}