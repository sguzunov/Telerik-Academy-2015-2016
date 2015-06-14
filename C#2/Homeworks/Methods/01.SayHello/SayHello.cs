using System;
using System.Collections.Generic;
using System.Threading;

// Write a method that asks the user for his name and prints “Hello, <name>”
// Write a program to test this method.

class SayHello
{
    static void Main()
    {
        SayHelloToSomebody();

    }

    static void SayHelloToSomebody()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Hello,{0}",name);
    }    
}

