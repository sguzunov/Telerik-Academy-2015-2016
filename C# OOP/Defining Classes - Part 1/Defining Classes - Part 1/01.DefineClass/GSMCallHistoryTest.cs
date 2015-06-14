using System;
using System.Collections.Generic;

class GSMCallHistoryTest
{

    private static double PRICEPERMINUTE = 0.37;
    GSM newPhone = new GSM("Samsung", "Sams Corp.");

    public GSMCallHistoryTest()
    {
 
    }

    private static Call[] testCalls = 
        {
            new Call("08/04/2001","10:50:12","08998525178",250),
            new Call("21/05/2011","19:50:02","08793645178",196),
            new Call("31/12/2000","23:23:23","08893641238",100),
            new Call("01/01/2005","12:05:00","09893602587",196)            
        };

    public void CreateCallHistory()
    {
        for (int i = 0; i < testCalls.Length; i++)
        {
            newPhone.AddCall(testCalls[i]);
        }
    }
    
    public void PrintCallHistory()
    {
        for (int i = 0; i < newPhone.callHistory.Count; i++)
        {
            Console.WriteLine("Call: {0}\nDate: {1}\nTime: {2}\nPhone Number: {3}\nDuration: {4}",
                           i + 1, newPhone.callHistory[i].Date, newPhone.callHistory[i].Time,
                           newPhone.callHistory[i].DialledNumber, newPhone.callHistory[i].Duration);                   
        }        
    }

    public void TotalPriceOfCalls()
    {
        double totalDuration = 0;
        double totalPrice = 0;
        for (int i = 0; i < newPhone.callHistory.Count; i++)
        {
            totalDuration += newPhone.callHistory[i].Duration;            
        }

        totalPrice = (totalDuration / 60) * PRICEPERMINUTE;
        Console.WriteLine("Total price of all calls: {0:F2}", totalPrice);
    }

    public void RemoveLongest()
    {
        Call longestCall = new Call();


        foreach (var call in newPhone.callHistory)
        {
            if (call.Duration >= longestCall.Duration)
            {
                longestCall = call;
            }
        }

        newPhone.DeleteCall(longestCall);

        double totalDuration = 0;
        double totalPrice = 0;
        for (int i = 0; i < newPhone.callHistory.Count; i++)
        {
            totalDuration += newPhone.callHistory[i].Duration;
        }

        totalPrice = (totalDuration / 60) * PRICEPERMINUTE;
        Console.WriteLine("Total price of reduced calls: {0:F2}", totalPrice);
    }

    public void ClearHistory()
    {
        newPhone.ClearCallHistory();
    }
   
}

