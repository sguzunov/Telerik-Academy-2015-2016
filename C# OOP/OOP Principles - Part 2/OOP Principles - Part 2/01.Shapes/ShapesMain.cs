namespace Shapes
{
    using System;
    using Shapes.Models;
    using Shapes.Interfaces;
    using System.Collections.Generic;

    public class ShapesMain
    {
        static void Main()
        {
            ISurface[] figures = 
            {
                new Rectangle(4,8),
                new Square(4),
                new Triangle(2.5,3),
                new Rectangle(8.5,5),
                new Square(5.2),
                new Triangle(11,2)                
            };

            foreach (var item in figures)
            {
                Console.WriteLine(item.CalculateSurface());
            }
        }
    }

    /*     
    Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
    Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (heightwidth for rectangle and heightwidth/2 for triangle).
    Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
    Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array. 
     */
}
