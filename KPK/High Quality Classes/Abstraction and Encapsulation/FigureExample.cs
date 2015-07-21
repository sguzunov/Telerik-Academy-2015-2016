namespace Abstraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FigureExample
    {
        static void Main()
        {
            Circle circle = new Circle(5);
            Console.WriteLine("I am a circle. " +
                "My perimeter is {0:f2}. My surface is {1:f2}.",
                circle.CalculatePerimeter(), circle.CalculateArea());

            Rectangle rectangle = new Rectangle(2, 3);
            Console.WriteLine("I am a rectangle. " +
                "My perimeter is {0:f2}. My surface is {1:f2}.",
                rectangle.CalculatePerimeter(), rectangle.CalculateArea());
        }
    }
}
