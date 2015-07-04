namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// The class provides a variety of extension methods for strings.
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// The method computes the MD5 hash value of a string and returns the hash as a 32-character, hexadecimal-formatted string. 
        /// </summary>
        /// <param name="input">A string the method is called on.</param>
        /// <returns>A 32-character, hexadecimal-formatted string.</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            var builder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary>
        /// The method checks if the given string is contained in a collection of true values(as strings).
        /// </summary>
        /// <param name="input">A string the method is called on.</param>
        /// <returns>A boolean value if the input string is a contained true value or not.</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// The method converts the given string to a short value. 
        /// </summary>
        /// <param name="input">A string the method is called on.</param>
        /// <remarks>If the conversion is impossible returns 0.</remarks>
        /// <returns>The converted short value.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// The method converts the given string to a integer value. 
        /// </summary>
        /// <param name="input">A string the method is called on.</param>
        /// <remarks>If the conversion is impossible returns 0.</remarks>
        /// <returns>The converted integer value.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// The method converts the given string to a long value. 
        /// </summary>
        /// <param name="input">A string the method is called on.</param>
        /// <remarks>If the conversion is impossible returns 0.</remarks>
        /// <returns>The converted long value.</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// The method converts the given string to a DateTime value. 
        /// </summary>
        /// <param name="input">A string the method is called on.</param>
        /// <remarks>If the conversion is impossible returns "1.1.0001 00:00:00".</remarks>
        /// <returns>The converted DateTime value.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// The method capitalizes the first letter of a given string.
        /// </summary>
        /// <param name="input">A string the method is called on.</param>
        /// <returns>A string begining with a capital letter.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// The method returns a string between two other contained strings.
        /// </summary>
        /// <param name="input">A string the method is called on.</param>
        /// <param name="startString">The string to begin the slice from.</param>
        /// <param name="endString">The string to end the slice.</param>
        /// <param name="startFrom">The exact position to start the search for the substring.</param>
        /// <remarks>An empty string is returned if the given parameters for search are invalid.</remarks>
        /// <returns>The sliced string.</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// The method changes the cyrillic letters to their latin representations.
        /// </summary>
        /// <param name="input">A string the method is called on.</param>
        /// <returns>A string with changed to latin letters.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// The method changes the latin letters to their cyrillic keyboard representations.
        /// </summary>
        /// <param name="input">A string the method is called on.</param>
        /// <returns>A string with changed to cyrillic letters.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// The method converts the given string into valid username.
        /// </summary>
        /// <param name="input">A string the method is called on.</param>
        /// <returns>A valid string for username.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// The method converts the given string into valid file name. 
        /// </summary>
        /// <param name="input">A string the method is called on.</param>
        /// <returns>A valid string for file name.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// The method returns a sliced substring with length the required number of characters starting from position 0.
        /// </summary>
        /// <param name="input">A string the method is called on.</param>
        /// <param name="charsCount">The number of characters.</param>
        /// <returns>A string with the required length of characters.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// The method returns a substring containing the file extension.
        /// </summary>
        /// <param name="fileName">A string the method is called on.</param>
        /// <returns>The file extension or empty string if such not found.</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// The method returns the type of file content depending on the file extension.
        /// </summary>
        /// <param name="fileExtension">A string containing a file extension</param>
        /// <returns>The type of file content.If such is not fount returns a default content type.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// The method converts a string to byte array.
        /// </summary>
        /// <param name="input">A string the method is called on.</param>
        /// <returns>An array of bytes containing the byte representation of the character from the given string.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}