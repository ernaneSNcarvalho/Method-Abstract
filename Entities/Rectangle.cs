using AbstractMethod.Entities.Enums;

namespace AbstractMethod.Entities
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
    }
}