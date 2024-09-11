using System;
using System.Collections.Generic;

namespace AP01.Entities
{
    // classes sao tipos referencia
    class Product
    {

        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        // implementacao do GetHashCode e Equals, para comparar os valores e nao as referencias

        //public override int GetHashCode()
        //{
        //    return Name.GetHashCode() + Price.GetHashCode();
        //}

        //public override bool Equals(object? obj)
        //{
        //    if(!(obj is Product))
        //    {
        //        return false;
        //    }
        //
        //    Product other = obj as Product;
        //    return Name.Equals(other.Name) && Price.Equals(other.Price);
        //}
    }
}
