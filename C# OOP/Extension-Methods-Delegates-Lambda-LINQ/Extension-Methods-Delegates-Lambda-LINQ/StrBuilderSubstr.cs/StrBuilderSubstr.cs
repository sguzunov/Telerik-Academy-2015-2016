namespace StrBuilderSubstr
{
    using System;
    using System.Text;

    public class AdditionToSubString
    {
        static void Main()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("My name is...");
            Console.WriteLine(builder.Substring(1,4));

        }
    }

    /*
    Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as       Substring in the class String.     
     */

}
