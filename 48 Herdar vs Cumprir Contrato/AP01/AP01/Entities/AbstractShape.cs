using AP01.Enums;
using System;

namespace AP01.Entities
{
    abstract class AbstractShape : IShape
    {

        public Color Color { get; set; }


        // declaro novamente indicando que ainda é um nétodo abstrato
        public abstract double Area();

    }
}
