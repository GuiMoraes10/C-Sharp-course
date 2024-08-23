
namespace ATV1.Entities
{
    public abstract class Shape
    {
        public string Color { get; private set; }

        public Shape(string color)
        {
            Color = color;
        }

        public virtual double Area()
        {
            return 0;
        }

    }
}
