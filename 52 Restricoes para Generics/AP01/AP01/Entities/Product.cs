using System;
using System.Globalization;

namespace AP01.Entities
{
    internal class Product : IComparable
    {

        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {return Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Compare error: argument is not a product");
            }
            // indica o objeto que sera comparado com o que chamara o metodo
            Product other = obj as Product;

            // retorna a comparacao do preco
            return Price.CompareTo(other.Price);
        }
    }
}
