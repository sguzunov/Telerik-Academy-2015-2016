using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.ILS.Common;

namespace StringExtensions
{
    class OperationOverString
    {
        static void Main(string[] args)
        {
            var md5Representation = StringExtension.ToMd5Hash("hello");
            var isTrueValue = StringExtension.ToBoolean("ok");
            var shortRepresentationOfString = StringExtension.ToShort("123");
            var integerRepresentationOfString = StringExtension.ToInteger("-25123");
            var longRepresentationOfString = StringExtension.ToLong(((long)Int32.MaxValue + 10).ToString());
            var dateTimeRepresentationOfString = StringExtension.ToDateTime("04/07/2015");
            var stringWithCapitalFirstLetter = StringExtension.CapitalizeFirstLetter("john");
            var foundSubstring = StringExtension.GetStringBetween("I am John. I am from Otava Canada.", "am", "Canada", 5);
            var stringWithLatinLetters = StringExtension.ConvertCyrillicToLatinLetters("Пешо");
            var stringWithCyrillicLetters = StringExtension.ConvertLatinToCyrillicKeyboard("Pesho");
            var validUserName = StringExtension.ToValidUsername(" Пецата@123");
            var validFleName = StringExtension.ToValidLatinFileName("стрингExtensions.cs");
            var firstNCharacters = StringExtension.GetFirstCharacters("stringExtensions", 6);
            var fileExtension = StringExtension.GetFileExtension("StringExtension.cs");
            var typeOfContent = StringExtension.ToContentType("jpeg");
            var byteRepresentationOfString = StringExtension.ToByteArray("hello");

            Console.WriteLine(md5Representation);
            Console.WriteLine(isTrueValue);
            Console.WriteLine(shortRepresentationOfString);
            Console.WriteLine(integerRepresentationOfString);
            Console.WriteLine(longRepresentationOfString);
            Console.WriteLine(dateTimeRepresentationOfString);
            Console.WriteLine(stringWithCapitalFirstLetter);
            Console.WriteLine(foundSubstring);
            Console.WriteLine(stringWithLatinLetters);
            Console.WriteLine(stringWithCyrillicLetters);
            Console.WriteLine(validUserName);
            Console.WriteLine(validFleName);
            Console.WriteLine(firstNCharacters);
            Console.WriteLine(fileExtension);
            Console.WriteLine(typeOfContent);
            Console.WriteLine(byteRepresentationOfString);
        }
    }
}