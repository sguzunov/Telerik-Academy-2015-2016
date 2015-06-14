namespace LongestString
{
    using System.Collections.Generic;
    using System.Linq;

    public static class ExtentionArray
    {
        public static string FindLongestString(this string[] arr)
        {
            var result = arr.OrderBy(x => x.Length);

            var newResult = result.ToArray();

            return newResult[newResult.Length-1];
        }

    }
}
