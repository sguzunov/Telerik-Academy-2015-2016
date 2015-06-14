using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter width");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter height");
        int M = int.Parse(Console.ReadLine());

        int[,] array = new int[N, M];
        int[,] bestArray = new int[3, 3];
        int sum = int.MinValue;
        int bestSum = int.MinValue;
        Random r = new Random();

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
			{
                array[row, col] = r.Next(0, 10);
			}
        }

        for (int row = 0; row < N-2; row++)
        {
            for (int col = 0; col < M-2; col++)
            {
                sum = array[row, col] + array[row, col + 1] + array[row, col + 2] +
                    array[row + 1, col] + array[row + 1, col + 1] + array[row + 1, col + 2] +
                    array[row + 2, col] + array[row + 2, col + 1] + array[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestArray[0, 0] = array[row, col];
                    bestArray[0, 1] = array[row, col + 1];
                    bestArray[0, 2] = array[row, col + 2];
                    bestArray[1, 0] = array[row + 1, col];
                    bestArray[1, 1] = array[row + 1, col + 1];
                    bestArray[1, 2] = array[row + 1, col + 2];
                    bestArray[2, 0] = array[row + 2, col];
                    bestArray[2, 1] = array[row + 2, col+1];
                    bestArray[2, 2] = array[row + 2, col+2];
 
                }

            }
        }

        Console.WriteLine();
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write("{0} ",bestArray[row,col]);
            }
            Console.WriteLine();
        }
        
    }
}

