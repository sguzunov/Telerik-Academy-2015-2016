namespace Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ExceptionsTest
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Array cannot be null");
            }

            if (arr.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty");
            }

            if (startIndex < 0 || startIndex > arr.Length - 1)
            {
                throw new IndexOutOfRangeException(string.Format("Start index must be in range ({0},{1})", 0, arr.Length - 1));
            }

            if (count > arr.Length - startIndex)
            {
                throw new ArgumentOutOfRangeException("Too big count.");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }
            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (str == null)
            {
                throw new ArgumentNullException("String cannot be null");
            }

            if (str == string.Empty)
            {
                throw new ArgumentException("String cannot be empty");
            }

            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException(string.Format("Count must be smaller than {0}", str.Length));
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static bool CheckPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main()
        {
            var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));

            //Console.WriteLine(ExtractEnding("I love C#", 2));
            //Console.WriteLine(ExtractEnding("Nakov", 4));
            //Console.WriteLine(ExtractEnding("beer", 4));
            //Console.WriteLine(ExtractEnding("Hi", 100));

            Console.WriteLine(CheckPrime(23));
            Console.WriteLine(CheckPrime(33));

            List<Exam> peterExams = new List<Exam>()
            {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
            };

            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}
