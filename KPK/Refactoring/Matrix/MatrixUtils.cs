namespace Matrix
{

    public static class MatrixUtils
    {
        private const int ALL_DIRECTIONS = 8;

        public static bool hasEmptyNeighbourCell(int[,] matrix, int currentRow, int currentCol)
        {
            int[] MovementsByRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] MovementsByCol = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int size = matrix.GetLength(0);

            for (int dir = 0; dir < ALL_DIRECTIONS; dir++)
            {
                if (currentRow + MovementsByRow[dir] >= size || currentRow + MovementsByRow[dir] < 0)
                {
                    MovementsByRow[dir] = 0;
                }

                if (currentCol + MovementsByCol[dir] >= size || currentCol + MovementsByCol[dir] < 0)
                {
                    MovementsByCol[dir] = 0;
                }

                if (matrix[currentRow + MovementsByRow[dir], currentCol + MovementsByCol[dir]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static void findFirstEmptyCell(int[,] matrix, out int currentRow, out int currentCol)
        {
            currentRow = 0;
            currentCol = 0;
            int size = matrix.GetLength(0);

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        currentRow = row;
                        currentCol = col;
                        return;
                    }
                }
            }
        }

        public static void ChangeDirection(ref int directionX, ref int directionY)
        {
            int[] MovementsByRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] MovementsByCol = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int newDirection = 0;

            for (int dir = 0; dir < ALL_DIRECTIONS; dir++)
            {
                if (MovementsByRow[dir] == directionX && MovementsByCol[dir] == directionY)
                {
                    newDirection = dir;
                    break;
                }
            }

            if (newDirection == 7)
            {
                directionX = MovementsByRow[0];
                directionY = MovementsByCol[0];
            }
            else
            {
                directionX = MovementsByRow[newDirection + 1];
                directionY = MovementsByCol[newDirection + 1];
            }
        }
    }
}
