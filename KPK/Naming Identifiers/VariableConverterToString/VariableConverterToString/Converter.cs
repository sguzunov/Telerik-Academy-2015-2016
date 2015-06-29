namespace VariableConverterToString
{
    using System;

    public static class Converter
    {
        private const int MaxCount = 6;

        public class BoolenlConverter
        {
            public void ConvertingBoolToString(bool booleanValue)
            {
                string booleanAsString = booleanValue.ToString();
                Console.WriteLine(booleanAsString);
            }
        }
    }
}
