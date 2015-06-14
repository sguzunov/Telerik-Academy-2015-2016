namespace StrBuilderSubstr
{
    using System;
    using System.Text;

    public static class ExtensionStringBuilder
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            StringBuilder result = new StringBuilder();

            if ((index > str.Length - 1)||(index < 0))
            {
                throw new IndexOutOfRangeException("Such a start position DOES NOT EXIST in this string.");
            }
            else
            {
                if ((index + length) >= str.Length)
                {
                    for (int i = index; i < str.Length; i++)
                    {
                        result.Append(str[i]);
                    }
                }
                else if ((index + length) < str.Length)
                {
                    for (int i = index; i < index + length; i++)
                    {
                        result.Append(str[i]);
                    }
                }

                return result;
            }
        } 
    }
}
