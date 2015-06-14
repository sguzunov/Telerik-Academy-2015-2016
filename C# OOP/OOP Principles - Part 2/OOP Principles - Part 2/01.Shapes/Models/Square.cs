namespace Shapes.Models
{
    public class Square : Shape
    {
        public Square(double side)
            : base(side, side)
        { 
        }

        public override string CalculateSurface()
        {
            double surface = base.Width * base.Height;
            return string.Format("This square's surface is: {0}", surface);
        }
    }
}
