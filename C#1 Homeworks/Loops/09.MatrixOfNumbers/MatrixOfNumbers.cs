using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n;
          do{
            Console.WriteLine("Enter a number:");
            n=int.Parse(Console.ReadLine());
            }
            while(!((1<=n)&&(n<=20)));

          for (int row = 1; row <= n; row++)
          {
              for (int cow = row; cow <=n+(row-1); cow++)
              {
                  Console.Write(cow + " ");
                 
              }

              Console.WriteLine();
                            
          }



    }
}

