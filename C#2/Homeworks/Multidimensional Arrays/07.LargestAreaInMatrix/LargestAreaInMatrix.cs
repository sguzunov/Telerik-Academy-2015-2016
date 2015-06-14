using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

//  Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.


class LargestAreaInMatrix
{
    static void Main()
    {
        int[,] numbers =
        {
            { 1, 3, 2, 2, 2, 4 ,9, 9, 9, 2, 4 },
            { 3, 3, 3, 2, 4, 4 ,9, 3, 9, 4, 4 },
            { 4, 3, 1, 2, 3, 3 ,9, 1, 9, 3, 3 },
            { 4, 3, 1, 4, 9, 3 ,9, 1, 9, 3, 3 },
            { 4, 3, 3, 3, 9, 3 ,9, 3, 9, 3, 3 },
            { 4, 3, 3, 3, 9, 3 ,9, 1, 9, 3, 3 },
            { 4, 3, 3, 3, 9, 9 ,9, 1, 2, 9, 9 },
            { 4, 3, 3, 3, 3, 3 ,3, 1, 2, 3, 9 }      
            
        };

        char[,] visited = new char[numbers.GetLength(0), numbers.GetLength(1)];
        int queueLenght = numbers.GetLength(0) * numbers.GetLength(1);
        int[,] queue = new int[2, queueLenght];
        int queueIndex = -1;

        for (int i = 0; i < queue.GetLength(0); i++)
        {
            for (int j = 0; j < queue.GetLength(1); j++)
            {
                queue[i, j] = -1;
            }
        }

        int currentSize = 0, maxSize = 0, rowChecked = 0, colChecked = 0;

        for (int rowStarting = 0; rowStarting < numbers.GetLength(0); rowStarting++)
        {
            for (int colStarting = 0; colStarting < numbers.GetLength(1); colStarting++)
            {
                if (visited[rowStarting, colStarting] == 'y')
                {
                    continue;
                }
                rowChecked = rowStarting;
                colChecked = colStarting;

                do
                {
                    if((numbers[rowStarting,colStarting]==numbers[rowChecked,colChecked])&&visited[rowChecked,colChecked]!='y')
                    {
                        currentSize++;
                        visited[rowChecked,colChecked]='y';
                        if(rowChecked-1>=0)
                        {
                            if (numbers[rowChecked - 1, colChecked] == numbers[rowStarting, colStarting] && visited[rowChecked - 1, colChecked] != 'y')

                                {
                                queueIndex++;
                                queue[0, queueIndex] = rowChecked - 1;
                                queue[1, queueIndex] = colChecked;                               
                                }
                      }

                        if (rowChecked + 1 < numbers.GetLength(0))
                        {
                            if (numbers[rowChecked + 1, colChecked] == numbers[rowStarting, colStarting] && visited[rowChecked + 1, colChecked] != 'y')
                            {
                                queueIndex++;
                                queue[0, queueIndex] = rowChecked + 1;
                                queue[1, queueIndex] = colChecked;                               
                            }
                        }

                        if (rowChecked + 1 < numbers.GetLength(0))
                        {
                            if (numbers[rowChecked + 1, colChecked] == numbers[rowStarting, colStarting] && visited[rowChecked + 1, colChecked] != 'y')
                            {
                                queueIndex++;
                                queue[0, queueIndex] = rowChecked + 1;
                                queue[1, queueIndex] = colChecked;                               
                            }
                        }

                        if (colChecked + 1 < numbers.GetLength(1))
                        {
                            if (numbers[rowChecked, colChecked + 1] == numbers[rowStarting, colStarting] && visited[rowChecked , colChecked + 1] != 'y')
                            {
                                queueIndex++;
                                queue[0, queueIndex] = rowChecked;
                                queue[1, queueIndex] = colChecked + 1;
                                
                            }
                        }                       
                        
                    }
                    if (queueIndex > -1 && queue[0, queueIndex] != -1)
                    {
                        //take the row and col from queue and give -1
                        //to the queue - delete the queue entry

                        rowChecked = queue[0, queueIndex];
                        queue[0, queueIndex] = -1;
                        colChecked = queue[1, queueIndex];
                        queue[1, queueIndex] = -1;
                        queueIndex--;
                    }
                    else
                    {
                        break;
                    }
                }
                while (queueIndex > -2);
                
                 if (currentSize>maxSize)
                {
                    maxSize = currentSize;
                }
                currentSize = 0;
            }
        }
        Console.WriteLine(maxSize+1);
                
     }
}
        

   

