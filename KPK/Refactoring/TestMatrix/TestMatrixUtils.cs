namespace TestMatrix
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Matrix;

    [TestClass]
    public class TestMatrixUtils
    {
        // Tests for hasEmptyNeighbourCell()
        [TestMethod]
        public void AMiddleCellHavingNeighbourZeroMustHaveEmptyNeightbour()
        {
            var matrix = new int[3, 3] { 
                {1,2,3},
                {4,5,6},
                {7,0,9},
            };

            var hasEmptyNeighbour = MatrixUtils.hasEmptyNeighbourCell(matrix, 1, 1);

            Assert.IsTrue(hasEmptyNeighbour, "The middle cell must have an empty neighbour.");
        }

        [TestMethod]
        public void AnEndCellHavingNeighbourZeroMustHaveEmptyNeightbour()
        {
            var matrix = new int[3, 3] { 
                {1,2,3},
                {4,5,6},
                {7,0,9},
            };

            var hasEmptyNeighbour = MatrixUtils.hasEmptyNeighbourCell(matrix, 2, 2);

            Assert.IsTrue(hasEmptyNeighbour, "The end cell must have an empty neighbour.");
        }

        [TestMethod]
        public void AFirstCellHavingNeighbourZeroMustHaveEmptyNeightbour()
        {
            var matrix = new int[3, 3] { 
                {1,0,3},
                {4,5,6},
                {7,0,9},
            };

            var hasEmptyNeighbour = MatrixUtils.hasEmptyNeighbourCell(matrix, 0, 0);

            Assert.IsTrue(hasEmptyNeighbour, "The first cell must have an empty neighbour.");
        }

        [TestMethod]
        public void AMiddleCellNotHavingNeighbourZeroMustNotHaveEmptyNeightbour()
        {
            var matrix = new int[3, 3] { 
                {1,2,3},
                {4,5,6},
                {7,8,9},
            };

            var hasEmptyNeighbour = MatrixUtils.hasEmptyNeighbourCell(matrix, 1, 1);

            Assert.IsFalse(hasEmptyNeighbour, "The middle cell must not have an empty neighbour.");
        }

        [TestMethod]
        public void AFirstCellNotHavingNeighbourZeroMustNotHaveEmptyNeightbour()
        {
            var matrix = new int[3, 3] { 
                {1,2,3},
                {4,5,6},
                {7,0,9},
            };

            var hasEmptyNeighbour = MatrixUtils.hasEmptyNeighbourCell(matrix, 0, 0);

            Assert.IsFalse(hasEmptyNeighbour, "The first cell must not have an empty neighbour.");
        }

        [TestMethod]
        public void AnEndCellNotHavingNeighbourZeroMustNotHaveEmptyNeightbour()
        {
            var matrix = new int[3, 3] { 
                {1,2,3},
                {4,5,6},
                {0,8,9},
            };

            var hasEmptyNeighbour = MatrixUtils.hasEmptyNeighbourCell(matrix, 2, 2);

            Assert.IsFalse(hasEmptyNeighbour, "The end cell must not have an empty neighbour.");
        }

        // Tests for findFirstEmptyCell()
        [TestMethod]
        public void AMatrixNotHavingEmptyCellMustNotChangeRowAndColToNewPosition()
        {
            var matrix = new int[3, 3] { 
                {1,2,3},
                {4,5,6},
                {7,8,9},
            };

            int row = 0;
            int col = 0;
            MatrixUtils.findFirstEmptyCell(matrix, out row, out col);

            Assert.IsTrue(row == 0 && col == 0, "The row and col must return first cell.");
        }

        [TestMethod]
        public void AMatrixHavingEmptyCellMustChangeRowAndColToNewPosition()
        {
            var matrix = new int[3, 3] { 
                {1,0,3},
                {4,5,6},
                {7,8,9},
            };

            int row;
            int col;
            MatrixUtils.findFirstEmptyCell(matrix, out row, out col);

            Assert.IsTrue(row == 0 && col == 1, "The row and col must be changed to first row and second col.");
        }

        // Tests for ChangeDirection
        [TestMethod]
        public void DirectionMustBeChangedToNextPossibleWhichIsDown()
        {
            int dirX = 1;
            int dirY = 1;

            MatrixUtils.ChangeDirection(ref dirX, ref dirY);

            Assert.IsTrue(dirX == 1 && dirY == 0, "The direction must be changed to down.");
        }

        [TestMethod]
        public void DirectionMustBeChangedToNextPossibleWhichIsLeft()
        {
            int dirX = 1;
            int dirY = -1;

            MatrixUtils.ChangeDirection(ref dirX, ref dirY);

            Assert.IsTrue(dirX == 0 && dirY == -1, "The direction must be changed to left.");
        }

        [TestMethod]
        public void WhenCurrentDirectionIsLastPossibleMustChangedToFirstWhichIsDownAndRight()
        {
            int dirX = 0;
            int dirY = 1;

            MatrixUtils.ChangeDirection(ref dirX, ref dirY);

            Assert.IsTrue(dirX == 1 && dirY == 1, "The direction must be changed to down and left.");
        }
    }
}
