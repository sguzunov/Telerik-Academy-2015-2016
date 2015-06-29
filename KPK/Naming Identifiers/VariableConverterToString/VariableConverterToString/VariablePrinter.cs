namespace VariableConverterToString
{
    using System;

    public class VariablePrinter
    {
        public static void Main()
        {
            var printer = new Converter.BoolenlConverter();
            printer.ConvertingBoolToString(false);
            printer.ConvertingBoolToString(true);            
        }
    }
}
