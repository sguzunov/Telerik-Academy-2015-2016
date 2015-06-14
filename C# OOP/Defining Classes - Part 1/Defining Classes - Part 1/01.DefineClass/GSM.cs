using System;
using System.Collections.Generic;

public class GSM 
{
    private static double PRICE_PER_MINUTE = 0.37;
    private static GSM iphone4s;
    private string model;
    private string manufacturer;
    private double? price;
    private string owner;
    private Battery battery;
    private Display display;
    public List<Call> callHistory = new List<Call>(); 
    

    public GSM(string gsmModel, string gsmManufacturer):this(gsmModel,gsmManufacturer,200,"Vancho",new Battery("Standard"),new Display())
    {
        this.Model = gsmModel;
        this.Manufacturer = gsmManufacturer;               
    }

    public GSM(string gsmModel, string gsmManufacturer,double gsmPrice,string gsmOwner,Battery gsmBattery,Display gsmDisplay)
    {
        this.Model = gsmModel;
        this.Manufacturer = gsmManufacturer;
        this.Price = gsmPrice;
        this.Owner = gsmOwner;
        this.battery = gsmBattery;
        this.display = gsmDisplay;       
    }
    
    public List<Call> CallHistory
    {
        get
        {
            return this.callHistory;
        }
        set
        {
            this.callHistory = value;
        }
    }
    
    public GSM IPhone4S
    {
        get
        {
            return new GSM("IPhone 4s","Apple",600,"Kurt Cobain",new Battery("Standart",259,46,BatteryType.NiMH),new Display(4.0,16000000));
        }
    }

   
    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (value.Length == 0 || (value[0]<65 && value[0]>90))
            {
                throw new ArgumentException("Invalid data expression!");
            }
            else
            {
                this.model = value;
            }
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (value.Length == 0 || (value[0] < 65 && value[0] > 90))
            {
                throw new ArgumentException("Invalid data expression!");
            }
            else
            {
                this.manufacturer = value;
            }
        }
    }

    public double? Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value<=0)
            {
                throw new ArgumentOutOfRangeException("Invalid argument expression!");
            }
            else
            {
                this.price = value;
            }
        }
    }

    public string Owner
    {
        get
        {
            return this.owner;
        }
        set
        {
            if (value.Length == 0 || (value[0] < 65 && value[0] > 90))
            {
                throw new ArgumentException("Invalid data expression!");
            }
            else
            {
                this.owner = value;
            }
        }
    }

    public void AddCall(Call newCall)
    {
        this.CallHistory.Add(newCall);      
    }

    public void DeleteCall(Call currentCall)
    {
        for (int i = 0; i < callHistory.Count; i++)
        {
            if (callHistory[i].Date == currentCall.Date && callHistory[i].Time == currentCall.Time && callHistory[i].DialledNumber == currentCall.DialledNumber
                && callHistory[i].Duration == currentCall.Duration)
            {
                callHistory.RemoveAt(i);                 
            }            
        }
    }

    public void ClearCallHistory()
    {
        this.callHistory.Clear();        
    }

    public double CallPrice()
    {
        int sum = 0;
        double totalPrice = 0;
        for (int i = 0; i < callHistory.Count; i++)
        {
            sum += callHistory[i].Duration;        
        }

        totalPrice = (sum / 60);
        return totalPrice;
    }

    public void PrintHistory()
    {
        Console.WriteLine(callHistory);
    }

    
    public override string ToString()
    {                
         return string.Format("Model:{0}\nManufacturer:{1}\nPrice:{2}\nOwner:{3}\nBattery:({4},{5},{6},{7})," +
                             "\nDisplay:({8},{9})"
                            ,this.model, this.manufacturer, this.price, this.owner,
                            this.battery.BatteryModel,this.battery.HoursIdle,this.battery.HoursTalk,this.battery.Type,
                            this.display.Size,this.display.Colors);        
    }
    
}

