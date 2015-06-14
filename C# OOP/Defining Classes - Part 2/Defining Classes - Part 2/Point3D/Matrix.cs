namespace DefiningClasses
{
    using System;

    public class Matrix<T> where T : IComparable  // problem 8,9,10
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rowsCount, int colsCount)
        {
            this.Rows = rowsCount;
            this.Cols = colsCount;
            matrix = new T[rowsCount, colsCount];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid number for dimension!");
                }
                else
                {
                    this.rows = value;
                }
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid number for dimension!");
                }
                else
                {
                    this.cols = value;
                }
            }
        }

        public T this[int indexRow, int indexCol]
        {
            get
            {
                if (indexRow > this.Rows - 1 || indexRow < 0)
                {
                    throw new IndexOutOfRangeException("Invalid value of row!");
                }

                if (indexCol > this.Cols - 1 || indexCol < 0)
                {
                    throw new IndexOutOfRangeException("Invalid value of col!");
                }

                T result = this.matrix[indexRow, indexCol];
                return result;
            }
            set
            {
                if (indexRow > this.Rows - 1 || indexRow < 0)
                {
                    throw new IndexOutOfRangeException("Invalid value of row!");
                }

                if (indexCol > this.Cols - 1 || indexCol < 0)
                {
                    throw new IndexOutOfRangeException("Invalid value of col!");
                }

                this.matrix[indexRow, indexCol] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.Rows != secondMatrix.Rows) || (firstMatrix.Cols != secondMatrix.Cols))
            {
                throw new ArgumentException("The matrixes must be the same size!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, secondMatrix.Cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if ((firstMatrix.Rows != secondMatrix.Rows) || (firstMatrix.Cols != secondMatrix.Cols))
            {
                throw new ArgumentException("The matrixes must be the same size!");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, secondMatrix.Cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = (dynamic)firstMatrix[i, j] - secondMatrix[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Cols == secondMatrix.Rows)
            {
                Matrix<T> result = new Matrix<T>(firstMatrix.Rows, secondMatrix.Cols);
                for (int i = 0; i < result.Rows; i++)
                {
                    for (int j = 0; j < result.Cols; j++)
                    {
                        result[i, j] = (dynamic)0;
                        for (int k = 0; k < firstMatrix.Cols; k++)
                            result[i, j] = result[i, j] + (dynamic)firstMatrix[i, k] * secondMatrix[k, j];
                    }
                }
                return result;
            }
            else
            {
                throw new ArgumentException("The matrixes CANNOT be multiplied");
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool containsZero = true;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        containsZero = false;
                    }
                }
            }
            return containsZero;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool containsZero = true;

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        containsZero = false;
                    }
                }
            }
            return containsZero;
        }


    }
}
