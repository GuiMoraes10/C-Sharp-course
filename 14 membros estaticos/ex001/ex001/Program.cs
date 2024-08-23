using ex001;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual e a cotacao do dolar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dolares voce vai comprar? ");
            double dolares = double.Parse(Console.ReadLine());


            Console.Write("Valor a ser pago em reais = " + ConversorDeMoeda.CalcularValor(cotacao, dolares).ToString("F2"));
        }
    }
}

