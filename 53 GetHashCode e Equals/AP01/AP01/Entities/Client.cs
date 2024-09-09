using System;

namespace AP01.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }


        // sobrescrevendo o equals para personalizar a comparacao
        public override bool Equals(object? obj)
        {
            if (!(obj is Client))
            {
                return false;
            }

            // digo que o obj recebido eh um Client
            Client other = obj as Client;

            // retorno o tipo de comparacao personalizada que eu quero fazer
            return Email.Equals(other.Email);
        }

        // sobrescrevendo para implementacao do GetHashCode personalizado
        public override int GetHashCode()
        {
            // apenas retorna o GetHashCode do valor desejado
            return Email.GetHashCode();
        }
    }
}
