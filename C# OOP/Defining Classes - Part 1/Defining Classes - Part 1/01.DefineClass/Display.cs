using System;


public class Display
{
    private double size;
    private ulong colors;

    public Display():this(4.0, 256000)
    {
 
    }

    public Display(double displaySize, ulong numberOfColors)
    {
        this.Size = displaySize;
        this.Colors = numberOfColors;
    }

   public double Size
    {
        get
        {
            return this.size;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid value of size!");
            }
            else
            {
                this.size = value;
            }
        }
    }

   public ulong Colors
   {
       get
       {
           return this.colors;
       }
       set
       {
           if (value < 256000)
           {
               throw new ArgumentException("Invalid value for numberof colors!");
           }
           else
           {
               this.colors = value;
           }
       }

   }

}

