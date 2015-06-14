using System;
using System.Text;

class GravitationOnTheMoon
{
    static void Main()
    {
        double weigthOnTheEarth;
        Console.WriteLine("Type your weigth on the Earth:");
        weigthOnTheEarth = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));     
        Console.WriteLine("Your weigth on the Moon is :{0}",weigthOnTheEarth * 0.17);

        
    }
}


