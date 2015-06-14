namespace LongestString
{
    class LongestStringMain
    {
        static void Main()
        {
            string[] array = { "Ivan", "Gosho", "Gospodin", "Stoqn", "Monika", "Pesho" };

            string longestString = array.FindLongestString();

            System.Console.WriteLine(longestString);

        }
    }

    // Write a program to return the string with maximum length from an array of strings.use LINQ.
}
