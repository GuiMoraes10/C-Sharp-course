
namespace ATV1.Entities
{
    internal sealed class Circle : Shape
    {
        public double Radius { get; private set; }

        public Circle(string color, double radius) : base(color)
        { 
            Radius = radius;
        }

        public override double Area()
        {
            return double.Pi*(Radius*Radius);
        }

    }
}
