using System;

namespace AP01.Services
{
    internal class CalculationService
    {

        // desta forma eu indico que é um metodo generico que pode receber qualquer valor
        // where T : IComparable, para indicar que vou utilizar um tipo que implementa o IComparable
        // existem outras alternativas para where T : IComparable por ex:
        // where T : struct
        // where T : class
        // where T : unmanaged
        // where T : new()
        // where T : <base type name>
        // where T : U
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                // deve se utilizar o icomparable para comparar, pois caso seja > ele ira gerar um erro
                // se for > 0, ou seja 1, seignifica que é true
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }

    }
}
