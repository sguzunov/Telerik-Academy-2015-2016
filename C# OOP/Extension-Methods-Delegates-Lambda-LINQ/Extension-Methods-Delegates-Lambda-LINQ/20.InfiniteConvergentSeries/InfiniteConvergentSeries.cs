namespace InfiniteConvergentSeries
{
    using System;
    using System.Numerics;

    public delegate double ConvergentSeries(double precision);

    
    class InfiniteSeries
    {
        static void Main()
        {
            var conDelegate1 = new ConvergentSeries(ConvergentSum);
            var conDelegate2 = new ConvergentSeries(ConvergentSeriesSign);
            var conDelegate3 = new ConvergentSeries(ConvergentSumOfFactorial);

            Console.WriteLine("1 + 1/2 + 1/4 + 1/8 + ... with precision {0} = {1}",
               0.01, CalculateConvergentSeries(0.01, conDelegate1));

            Console.WriteLine("1 + 1/2 - 1/4 + 1/8 - ... with precision {0} = {1}",
                0.01, CalculateConvergentSeries(0.01, conDelegate2));

            Console.WriteLine("1 + 1/2! + 1/3! + 1/4! - ... with precision {0} = {1}",
               0.01, CalculateConvergentSeries(0.01, conDelegate3));
        }

        public static double CalculateConvergentSeries(double precision, ConvergentSeries dlg)
        {
            return dlg(precision);
        }

        private static BigInteger Factorial(int number)
        {
            BigInteger result = 1;

            if (number < 0)
            {
                throw new ArgumentException("Incorrect data to calculate factorial!");
            }

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

        private static BigInteger PowerOfTwo(int number)
        {
            BigInteger result = 1;

            for (int i = 0; i < number; i++)
            {
                result *= i;
            }

            return result;
        }

        private static double ConvergentSum(double precision)
        {
            double result = 1;
            double previous = 0;
            int count = 1;

            while (result - previous > previous)
            {
                previous = result;
                result += 1 / (double)PowerOfTwo(count);
                count++;
            }

            return result;
        }

        private static double ConvergentSumOfFactorial(double precision)
        {
            double result = 1;
            double previous = 0;
            int count = 2;

            while (result - previous > previous)
            {
                previous = result;
                result += 1 / (double)Factorial(count);
                count++;
            }

            return result;
        }

        private static double ConvergentSeriesSign(double precision)
        {
            double result = 1;
            double previous = 0;
            int count = 1;

            while (Math.Abs(result - previous) > 0)            
            {
                previous = result;

                if (count % 2 == 1)
                {
                    result += (double)PowerOfTwo(count);
                }
                else
                {
                    result -= (double)PowerOfTwo(count);
                }

                count++;
            }

            return result;
        }
    }
    
    /*
      By using delegates develop an universal static method to calculate the sum of infinite convergent series with given precision depending on a function 
      of its term. By using proper functions for the term calculate with a 2-digit precision the sum of the infinite series:

1 + 1/2 + 1/4 + 1/8 + 1/16 + …
1 + 1/2! + 1/3! + 1/4! + 1/5! + …
1 + 1/2 - 1/4 + 1/8 - 1/16 + …   
      
     */

}
