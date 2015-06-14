using System;
using System.Text.RegularExpressions;

public class Call
{
    private string date;
    private string time;
    private string dialledNumber;
    private ushort duration;

    public Call():this("01/01/2000","00:00:00","359880000000",0)
    {
 
    }

    public Call(string callDate,string callTime,string callDialledNumber,ushort callDuration)
    {
        this.Date = callDate;
        this.Time = callTime;
        this.DialledNumber = callDialledNumber;
        this.Duration = callDuration;
    }


    public string Date
    {
        get
        {
            return this.date;
        }
        set
        {            
            if (IsDateTime(value) == false)
            {
                throw new FormatException("Incorrect input data!");
            }
            else
            {
                this.date = value;
            } 
        }
    }

     public string Time
    {
        get
        {
            return this.time;
        }
        set
        {            
            if (IsDateTime(value)==false)
            {
                throw new FormatException("Incorrect input data!");
            }
            else
           {
                this.time = value;
            } 
        }
    }

     public string DialledNumber
     {
         get
         {
             return this.dialledNumber;
         }
         set
         {
           // if (!IsCorrectNumber(value))
           // {
           //    throw new FormatException("Incorrect input data!");
            //}
           // else
           // {
              this.dialledNumber = value; 
           // } 
         }
     }

     public ushort Duration
     {
         get
         {
             return this.duration;
         }
         set
         {
             if (value < 0)
             {
                 throw new ArgumentException("Incorrect input data!");
             }
             else
             {
                 this.duration = value;
             } 
         } 
     }

     private bool IsCorrectNumber(String strPhone)
     {
         Regex objPhonePattern = new Regex(@"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$");
         return objPhonePattern.IsMatch(strPhone);
     }
    
    private static bool IsDateTime(string txtDate)
    {
        DateTime tempDate;
        return DateTime.TryParse(txtDate, out tempDate) ? true : false;
    }

}

