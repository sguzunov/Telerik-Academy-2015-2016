using System;

class DivideBySevenAndFive
{
    static void Main()
    {

       int x;
       Console.WriteLine("Insert a number:");
       x = int.Parse(Console.ReadLine());      
       Console.WriteLine((x%5==0)&&(x%7==0)?"true":"false");     


    }
}

