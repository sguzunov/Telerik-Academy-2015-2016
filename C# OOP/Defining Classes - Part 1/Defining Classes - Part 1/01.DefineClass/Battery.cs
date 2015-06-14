using System;


public class Battery
{
    private string baterryModel;
    private double? hoursIdle;
    private double? hoursTalk;
    private BatteryType type;

    

    public Battery(string model):this(model,200,40,BatteryType.LiIon)
    {
        this.baterryModel = model;        
    }

    public Battery(string model, double idleHours, double talkHours, BatteryType batteryType)
    {
        this.BatteryModel = model;
        this.HoursIdle = idleHours;
        this.HoursTalk = talkHours;
        this.Type = batteryType;
    }
 
    public string BatteryModel
    {
        get
        {
            return this.baterryModel;
        }
        private set
        {
            this.baterryModel = value;
        }
    }

    public double? HoursIdle
    {
        get
        {
            return this.hoursIdle;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid value input!");
            }
            else
            {
                this.hoursIdle = value;
            }
        }
    }

    public double? HoursTalk
    {
        get
        {
            return this.hoursTalk;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid value input!");
            }
            else
            {
                this.hoursTalk = value;
            }
        }
    }

    public BatteryType Type
    {
        get
        {
            return this.type;
        }
        set
        {
          //  if (value.ToString() != "LiIon" || value.ToString() != "NiMH" || value.ToString() != "NiCd")
          //  {
          //      throw new ArgumentException("Incorrect input data!");
          //  }
          //  else
          //  {
                this.type = (BatteryType)Enum.Parse(typeof(BatteryType), value.ToString());
           // }            
        }
    }


}

