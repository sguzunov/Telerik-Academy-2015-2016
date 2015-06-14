namespace Shapes.Models
{
    using System;

    public class Rectangle : Shape
    {
        public Rectangle(double wth, double hth)
            : base(wth, hth)
        { 
        }

        public override string CalculateSurface()
        {
            double surface = base.Height * base.Width;
            return string.Format("This rectangle's surface is: {0}", surface);
        }
    }
}
