using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Write a program that removes from a text file all words listed in given another text file.Handle all possible exceptions in your methods.

class RemoveWords
{
    static void Main()
    {
        Console.Write("Enter the path to the file with text: ");
        string pathText = Console.ReadLine();
        Console.Write("Enter the path to the file with words: ");
        string pathWords = Console.ReadLine();
        string words=string.Empty;

        using (StreamReader reader = new StreamReader(pathWords))
        {
            words = reader.ReadToEnd();
        }

        string[] byWords = words.Split(' ', ',', '.');

        try
        {
            using (StreamWriter sw = new StreamWriter("result.txt"))
            {
                using (StreamReader sr = new StreamReader(pathText))
                {
                    string line = string.Empty;

                    while ((line = sr.ReadLine()) != null)
                    {
                        for (int i = 0; i < byWords.Length; i++)
                        {
                            if (line.Contains(byWords[i]))
                            {
                                line = line.Replace(byWords[i], string.Empty);
                            }
                        }
                        sw.Write(line);
                    }

                }
            }

        }
        catch (FieldAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Your fail is DONE!");
        }

    }
}

