namespace Abstraction
{
    using System;

    public abstract class Figure : IFigure
    {
        private double width;
        private double height;
        private double radius;

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public Figure(double radius)
        {
            this.Radius = radius;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be positive number.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be positive number.");
                }

                this.height = value;
            }
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Radius must be positive number.");
                }

                this.radius = value;
            }
        }

        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();
    }
}
