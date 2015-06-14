using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

// Write a program that fills and prints a matrix of size (n, n).


class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter the of matrix ");
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[n,n];
        int firstCounter=1;
        int secondCounter = 1;
        int thirdCounter=1;
        int fourthCounter = 1;
      
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j =0; j < array.GetLength(1); j++)
            {                   
                array[i,j] = firstCounter++;
            }
            
        }
        
        // Printing the first matrix

        for (int col= 0; col < array.GetLength(0); col++) 
        {
            for (int row = 0; row < array.GetLength(1); row++)
            {
                Console.Write("{0} ", array[row, col]);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
       
        // Printing the second matrix               

        for (int col = 0; col < array.GetLength(0); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < array.GetLength(1); row++)
                {
                    array[row, col] = secondCounter++;                    
                }
            }
            else
            {
                for (int row = array.GetLength(1)-1; row >=0 ; row--)
                {
                    array[row, col] = secondCounter++;                    
                }           
            
            }
            Console.WriteLine();                        
        }

        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write("{0} ", array[row, col]);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();

        // Printing the third matrix
        
        for (int row = n-1; row >= 0; row--)
        {
            for (int col = 0; row+col < n; col++)
            {
                array[row + col, col] = thirdCounter++;
            }
        }

        for (int col = 1; col < n; col++)
        {
            for (int row = 0; row+col < n; row++)
            {
                array[row, row + col] = thirdCounter++;
            }
                        
        }

        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write("{0} ", array[row, col]);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        // Print the fourth matrix

        int begining = 0;
        int ending = n;

        while ((ending - begining) > 0)
        {
            for (int row = begining; row < ending; row++)
            {
                array[row, begining] = fourthCounter++;
            }

            for (int col = begining+1; col < ending; col++)
            {
                array[ending - 1, col] = fourthCounter++;
            }

            for (int row = ending-2; row >= begining ; row--)
            {
                array[row, ending - 1] = fourthCounter++;
            }

            for (int col = ending-2; col >=begining+1; col--)
            {
                array[begining, col] = fourthCounter++;                
            }
            
            begining++;
            ending--;        
        }

        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write("{0}   ", array[row, col]);        
            }
            Console.WriteLine();
        }

    }
}

