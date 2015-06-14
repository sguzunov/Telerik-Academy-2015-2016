using System;
using System.Collections.Generic;

public class GSMTest
{
    GSM g = new GSM("Lenovo","Lenovo Corp.");
    
    public GSMTest()
    {
 
    }

    public void CreateSomeGSM()
    {
        GSM firstPhone = new GSM("Samsung", "Samsung Corp.", 500, "Ivan Petrov", new Battery("Standard", 390, 77, BatteryType.LiIon), new Display(4.5, 16000000));
        GSM secondPhone = new GSM("Sony", "Sony Corp.", 720, "Romen Ivanov", new Battery("Standard", 400, 56, BatteryType.NiCd), new Display(4.3, 256000));
        GSM thirdPhone = new GSM("Nokia", "Microsoft", 450, "Gregory House", new Battery("Standard", 600, 70, BatteryType.LiIon), new Display(5.0, 16000000));

        GSM[] phones = new GSM[] { firstPhone, secondPhone, thirdPhone };

        foreach (var phone in phones)
        {
            Console.WriteLine(phone);
            Console.WriteLine();
        }
        
        Console.WriteLine(g.IPhone4S);
    }
    
}

