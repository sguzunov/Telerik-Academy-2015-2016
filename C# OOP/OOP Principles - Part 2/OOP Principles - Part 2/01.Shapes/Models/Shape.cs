namespace Shapes.Models
{
    using System;
    using Shapes.Interfaces;

    public abstract class Shape : ISurface
    {
        private double width;
        private double height;

        public Shape(double wth, double hth)
        {
            this.Width = wth;
            this.Height = hth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(@"Incorrect input data.'Width' must be > 0.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(@"Incorrect input data.'Height' must be > 0.");
                }

                this.height = value;
            }
        }

        public abstract string CalculateSurface();
                
    }
}
