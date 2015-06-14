using System;

class NumberAsWords
{
    static void Main()
    {
        Console.WriteLine("Enter a number from 0 to 999!");
        int num = int.Parse(Console.ReadLine());

        string[] fromZeroToNine = new string[10] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] fromTenToNineTeen = new string[10] {"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", 
                "seventeen", "eighteen", "nineteen"};
        string[] last = new string[10] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        if (num < 10)
        {
            Console.WriteLine(fromZeroToNine[num]);

        }
        else if ((num > 9) && (num < 20))
        {
            Console.WriteLine(fromTenToNineTeen[num % 10]);

        }

        else if ((num > 19) && (num < 100))
        {
            if (num % 10 == 0)
            {
                Console.WriteLine(last[num / 10]);
            }
            else
            {
                Console.WriteLine(last[num / 10] + " " + fromZeroToNine[num % 10]);
            }

        }

        else if ((num > 99) && (num < 1000))
        {
            if (num % 100 == 0)
            {
                Console.WriteLine(fromZeroToNine[num / 100] + " " + "hundred");
            }
            else if ((num - (num / 100) * 100) < 10)
            {
                Console.WriteLine(fromZeroToNine[num / 100] + " hundred and " + fromZeroToNine[num % 10]);
            }
            else if (((num - (num / 100) * 100) > 9) && ((num - (num / 100) * 100) < 20))
            {
                Console.WriteLine(fromZeroToNine[num / 100] + " hundred and " + fromTenToNineTeen[num % 10]);

            }
            else if (((num - (num / 100) * 100) > 19) && ((num - (num / 100) * 100) < 99))
            {
                Console.WriteLine(fromZeroToNine[num / 100] + " hundred and " + last[(num % 100) / 10] + fromZeroToNine[num % 10]);

            }

        }
    }
}

