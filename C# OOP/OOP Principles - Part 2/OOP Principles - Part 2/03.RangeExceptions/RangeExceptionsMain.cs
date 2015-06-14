namespace RangeExceptions
{
    using System;
    using System.Globalization;

    class RangeExceptionsMain
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");

            int number = int.Parse(Console.ReadLine());

            if (number < 0 || number > 100)
            {
                throw new InvalidRangeException<int>("The number must be in range [0...100]", 1, 100);
            }

            Console.WriteLine("Enter a date in format yyyy/MM/dd");

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "yyyy/MM/dd", CultureInfo.InvariantCulture);

            DateTime startDate=new DateTime(1980,1,10);
            DateTime endDate = new DateTime(2013, 12, 31);

            if (date < startDate || date > endDate)
            {
                throw new InvalidRangeException<DateTime>("Date must be in range [1.1.1980] - [31.12.2013]", startDate, endDate); 
            }
        }
    }

    /*
     * Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and a range 
       definition [start … end].
Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
     */ 

}
