namespace RefactorIfStatements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cell
    {
        private double xCoordinate;
        private double yCoordinate;

        public Cell(double xCoordinate, double yCoordinate)
        {
            this.X = xCoordinate;
            this.Y = yCoordinate;
        }

        public double X
        {
            get
            {
                return this.xCoordinate;
            }

            set
            {
                this.xCoordinate = value;
            }
        }

        public double Y
        {
            get
            {
                return this.yCoordinate;
            }

            set
            {
                this.yCoordinate = value;
            }
        }

        public void VisitCell()
        {
            // TODO
        }

        public static bool ShouldVisitCell()
        {
            // TODO
            throw new NotFiniteNumberException();
        }
    }
}
