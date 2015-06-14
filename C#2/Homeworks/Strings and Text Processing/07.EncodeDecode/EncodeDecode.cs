using System;
using System.Collections.Generic;
using System.Text;

/*
    Write a program that encodes and decodes a string using given encryption key (cipher).
    The key consists of a sequence of characters.
    The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the       second, etc. When the last key character is reached, the next is the first.
  
 */


class EncodeDecode
{
    static void Main()
    {
        Console.WriteLine("Entera text");
        string text = Console.ReadLine();
        Console.WriteLine("Enter a key");
        string key = Console.ReadLine();


        StringBuilder encoded = Encoding(text, key);
        Console.WriteLine("Encoded text is: {0}", encoded);
        Console.WriteLine("Decoded text is: {0}", Decoding(text, key, encoded)); 
               

    }
       

    static StringBuilder Encoding(string text,string key)
    {
        StringBuilder encoded = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            encoded.Append((char)(text[i] ^ key[i % key.Length]));
        }

        return encoded; 
    }

    static StringBuilder Decoding(string text, string key, StringBuilder encoded)
    {
        StringBuilder decoded = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            decoded.Append((char)(encoded[i] ^ key[i % key.Length]));
        }

        return decoded;
    }

}

