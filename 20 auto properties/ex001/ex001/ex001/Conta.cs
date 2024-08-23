using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex001
{
    class Conta
    {
        public string Nome { get; set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public Conta()
        {

        }

        public Conta(string nome, int numero, double saldo)
        {
            Saldo = saldo;
            Numero = numero;
            Nome = nome;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= (valor + 5);
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Nome + ", Saldo: $" + Saldo.ToString("F2");
        }

    }
}