namespace Abstraction
{
    using System;

    public class Circle : Figure
    {
        public Circle(double radius)
            : base(radius)
        {
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;

            return perimeter;
        }

        public override double CalculateArea()
        {
            double area = Math.PI * this.Radius * this.Radius;
            return area;
        }
    }
}
