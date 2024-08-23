using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ap015
{
    class Calculadora
    {

        // agora, com o static, eu nao preciso instanciar um objeto para utilizar estes atributos e metodos
        // ja que eles terao o mesmo resultado independente de um objeto
        public static double Pi = 3.14;

        public static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        public static double Volume(double raio)
        {
            return (4.0 / 3.0) * Pi * (Math.Pow(raio, 3));
        }


    }
}