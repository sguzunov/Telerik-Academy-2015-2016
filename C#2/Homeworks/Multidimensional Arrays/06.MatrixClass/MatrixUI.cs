using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

/*      Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing         the   matrix content and ToString().
*/
   
class MatrixUI
{
    static void Main()
    {
        Matrix matrix1 = new Matrix(2,2);
        matrix1[0, 0] = 4;
        matrix1[0, 1] = 7;
        matrix1[1, 0] = -17;
        matrix1[1, 1] = 16;
        
        Matrix matrix2 = new Matrix(2,2);
        matrix1[0, 0] = 21;
        matrix2[0, 1] = 2;
        matrix1[1, 0] = -1;
        matrix2[1, 1] = 24;

        Matrix sum = matrix1 + matrix2;
        Matrix subtraction = matrix1 - matrix2;
        Matrix multiplication = matrix1 * matrix2;
        Console.WriteLine("The sum:");
        Console.WriteLine(sum.ToString()); 
        Console.WriteLine();
        Console.WriteLine("The subraction:");
        Console.WriteLine(subtraction.ToString()); 
        Console.WriteLine();
        Console.WriteLine("The mu;tiplication:");
        Console.WriteLine(multiplication.ToString()); 

    }
        
}

