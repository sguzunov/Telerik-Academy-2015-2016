namespace Shapes.Models
{
    using System;

    public class Triangle : Shape
    {
        public Triangle(double wth, double hth)
            : base(wth, hth)
        { 
        }

        public override string CalculateSurface()
        {
            double surface = (base.Height * base.Width) / 2;
            return string.Format("This triangle's surface is: {0}", surface);
        }
    }
}
