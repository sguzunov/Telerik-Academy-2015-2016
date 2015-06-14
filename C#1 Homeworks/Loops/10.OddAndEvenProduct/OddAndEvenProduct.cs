using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string [] arr = Console.ReadLine().Split(' ');
        int productOdd=1;
        int productEven = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 != 0)
            {
                productOdd = productOdd * Convert.ToInt32(arr[i]);
                
            }

            if (i % 2 == 0)
            {
                productEven = productEven * Convert.ToInt32(arr[i]);

            }

        }


        if (productOdd == productEven)
        {
            Console.WriteLine("Yes , product={0}", productOdd + productEven);

        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Odd product={0}",productOdd);
            Console.WriteLine("Even product={0}", productEven);

        }

    }
}

