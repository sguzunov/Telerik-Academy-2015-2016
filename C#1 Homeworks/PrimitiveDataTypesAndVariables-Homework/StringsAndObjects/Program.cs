using System;

class Program
{
    static void Main()
    {
        string sVar1 = "Hello";
        string sVar2 = "World";
        object oVariable1 = sVar1 + " " + sVar2;
        string sVar3 = (string)oVariable1;
        Console.WriteLine(sVar3);


    }
}

