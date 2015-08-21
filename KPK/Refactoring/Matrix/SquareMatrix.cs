namespace Matrix
{
    using log4net;
    using log4net.Config;
    using System;
    using System.Text;

    public class SquareMatrix
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(SquareMatrix));

        private const int INITIAL_DIRECTION_X = 1;
        private const int INITIAL_DIRECTION_Y = 1;

        private int size;
        private int[,] matrixField;
                
        public SquareMatrix(int size)
        {
            this.Size = size;
            this.matrixField = new int[size, size];
        }

        public int Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value < 1 || value > 100)
                {                    
                    throw new ArgumentOutOfRangeException("Matrix size must be a between 1 and 100.");                    
                }

                this.size = value;

                XmlConfigurator.Configure();
                Log.Debug("Debug msg test");
                Log.Error("Error msg test");

            }
        }

        public int[,] MatrixField
        {
            get
            {
                return this.matrixField;
            }
        }

        public int this[int rowNumber, int colNumber]
        {
            get
            {
                return this.matrixField[rowNumber, colNumber];
            }

            set
            {
                if (rowNumber < 0)
                {
                    throw new ArgumentOutOfRangeException("Row number must not be smaller than 0.");
                }

                if (colNumber < 0)
                {
                    throw new ArgumentOutOfRangeException("Column number must be smaller than 0.");
                }

                this.matrixField[rowNumber, colNumber] = value;
            }
        }

        public void FillClockwiseMatrix()
        {
            int cellValue = 1;
            int row = 0;
            int col = 0;
            int directionX = INITIAL_DIRECTION_X;
            int directionY = INITIAL_DIRECTION_Y;
            int size = this.Size;

            while (cellValue <= size * size)
            {
                this[row, col] = cellValue++;
                int[,] matrixField = this.MatrixField;
                if (MatrixUtils.hasEmptyNeighbourCell(matrixField, row, col))
                {
                    while (row + directionX >= size || row + directionX < 0 ||
                        col + directionY >= size || col + directionY < 0 ||
                        this[row + directionX, col + directionY] != 0)
                    {
                        MatrixUtils.ChangeDirection(ref directionX, ref directionY);
                    }

                    // The next cell gets it's new position
                    row += directionX;
                    col += directionY;
                }
                else
                {
                    MatrixUtils.findFirstEmptyCell(matrixField, out row, out col);

                    // When a new cell is found the direction gets initial state
                    directionX = INITIAL_DIRECTION_X;
                    directionY = INITIAL_DIRECTION_Y;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.Size; row++)
            {
                for (int col = 0; col < this.Size; col++)
                {
                    result.AppendFormat("{0,3}", this[row, col]);
                }

                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }
    }
}
