using ap01.Services;

// DELEGATES
// É uma referência para um ou mais métodos com type safety

// delegates pré definidos: Action, Func, Predicate

namespace Ap01
{
    // desta forma indico que ele será uma referência para a minha funcao e recebera dois double, retornando outro double
    delegate double BinaryNumericOperation(double n1,  double n2);

    class Program
    {


        static void Main(string[] args)
        {

            double a = 10;
            double b = 12;

            // Agora, defino o BinaryNumericOperation declarado como uma referência ao meu metodo que contem a operacao de soma
            BinaryNumericOperation op = CalculationService.Sum;

            // double result = CalculationService.Sum(a, b);
            // posso agora chamar diretamente esta referencia com os parametros para o metodo
            double result = op(a, b);
            Console.WriteLine(result);

        }
    }
}