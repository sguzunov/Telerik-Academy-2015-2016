using System;

class PrintADeckOf52Cards
{
    static void Main()
    {

        for (int i = 2; i <= 14; i++)
        {

            for (int j = 6; j >= 3; j--)
            {

                switch (i)
                {

                    case 2: Console.Write("{0}{1}", i, (char)j); break;
                    case 3: Console.Write("{0}{1}", i, (char)j); break;
                    case 4: Console.Write("{0}{1}", i, (char)j); break;
                    case 5: Console.Write("{0}{1}", i, (char)j); break;
                    case 6: Console.Write("{0}{1}", i, (char)j); break;
                    case 7: Console.Write("{0}{1}", i, (char)j); break;
                    case 8: Console.Write("{0}{1}", i, (char)j); break;
                    case 9: Console.Write("{0}{1}", i, (char)j); break;
                    case 10: Console.Write("{0}{1}", i, (char)j); break;
                    case 11: Console.Write("{0}{1}", "J", (char)j); break;
                    case 12: Console.Write("{0}{1}", "Q", (char)j); break;
                    case 13: Console.Write("{0}{1}", "K", (char)j); break;
                    case 14: Console.Write("{0}{1}", "A", (char)j); break;

                }

                
            }
            Console.WriteLine();
        }
    }
}