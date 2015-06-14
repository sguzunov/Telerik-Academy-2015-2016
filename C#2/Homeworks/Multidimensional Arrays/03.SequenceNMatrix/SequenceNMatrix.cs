using System;
using System.Collections.Generic;
using System.Threading;

/*
     We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line,
     column or diagonal.
     Write a program that finds the longest sequence of equal strings in the matrix.
 */

class SequenceNMatrix
{
    static void Main()
    {
        string[,] array =
        {
           { "ha", "fifi", "ho", "hi" }, 
           { "fo", "ha", "hi", "xx" }, 
           { "xxx", "ho", "ha", "xx" }
        };

        int currentSequence = 1;
        int bestSequence = 0;
        string element = "";

        // by row
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1)-1; col++)
            {
                if (array[row, col] == array[row, col + 1])
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence;
                        element = array[row, col];
                    }
                    currentSequence = 1;

                }
                                
            }

            if (currentSequence > bestSequence)
            {
                bestSequence = currentSequence;
                element = array[row,array.GetLength(1)-1];
            }

        }

        // by collumn
        for (int col = 0; col < array.GetLength(1); col++)
        {
            for (int row = 0; row < array.GetLength(0)-1; row++)
            {
                if (array[row, col] == array[row + 1, col])
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence;
                        element = array[row, col];
                    }
                    currentSequence = 1;                                    
                }

            }
            if (currentSequence > bestSequence)
            {
                bestSequence = currentSequence;
                element = array[array.GetLength(0) - 1, col];
            }
        }

  /*      // diagonal
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {   
                for (int k = row, l = col; (k < array.GetLength(0)-1 ) && (l < array.GetLength(1)-1 ); k++,l++)
                {
                    if (array[l, k] == array[l + 1, k + 1])
                    {
                        currentSequence++;
                    }                    
                    if (currentSequence > bestSequence)
                     {
                          bestSequence = currentSequence;
                          element = array[l, k];

                     }                                     
                
                }

            }

        }
        
    */
        for (int i = 0; i < bestSequence; i++)
        {
            Console.Write("{0} ", element);
        }
        Console.WriteLine();      
    }
}

