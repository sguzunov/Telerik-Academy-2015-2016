namespace Size
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Figure
    {
        private double width;
        private double height;

        public Figure(double width, double height)
        {

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
                    throw new ArgumentOutOfRangeException("The width must be a number bigger than 0");
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
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The height must be a number bigger than 0");
                }

                this.height = value;
            }
        }

        public static Figure GetRotatedFigure(Figure figure, double angleOfRotation)
        {
            double sinusWidth = Math.Abs(Math.Sin(angleOfRotation)) * figure.Width;
            double cosinusWidth = Math.Abs(Math.Cos(angleOfRotation)) * figure.Width;
            double sinusHeight = Math.Abs(Math.Sin(angleOfRotation)) * figure.Height;
            double cosinusHeight = Math.Abs(Math.Cos(angleOfRotation)) * figure.Height;

            double width = sinusHeight + cosinusWidth;
            double height = sinusWidth + cosinusHeight;

            Figure rotatedFigure = new Figure(width, height);

            return rotatedFigure;
        }
    }
}
