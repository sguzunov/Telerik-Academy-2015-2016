using System;
using System.Text;
using System.IO;

/* Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
 */ 


class MaximalAreaSum
{
  
    static void Main()
    {
        Console.Write("Enter the path of ypur fail: ");
        string path = Console.ReadLine();

        int[,] matrix = GetMatrix(path);
        int sum = GetTheBestSum(matrix);
        Console.WriteLine("The best sum is: {0}", sum);

    }

    static int GetTheBestSum(int[,] matrix)
    {
        int sum = 0, currentSum = 0;

        for (int row = 0; row < matrix.GetLength(0)-1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-1; col++)
            {
                currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (currentSum > sum)
                {
                    sum = currentSum;
                    currentSum = 0;
                }
            }            
        }
        return sum;        
    }

    static int[,] GetMatrix(string path)
    {
        using (StreamReader sr = new StreamReader(path))
        {
            int size = int.Parse(sr.ReadLine());
            int[,] matrix = new int[size, size];
            string line = string.Empty;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                line = sr.ReadLine();
                string[] cells = line.Split(' ');

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(cells[col]);

                } // cols 

            }// rows

            return matrix;
        }        

    }// end method
}

