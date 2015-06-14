using System;

class PrintTheASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        int i,j;
        for (i = 33; i < 127; i++)
        {
            Console.WriteLine("{0}  --->  {1}",i,(char)i);
        }
        Console.WriteLine();
        for (j = 161; j <= 255; j++)
        {
            Console.WriteLine("{0}  --->  {1}", j, (char)j);
        }  

        
    }
}

