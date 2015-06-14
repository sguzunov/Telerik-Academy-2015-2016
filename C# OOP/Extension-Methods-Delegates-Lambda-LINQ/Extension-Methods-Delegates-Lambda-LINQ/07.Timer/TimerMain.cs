namespace TimeSpace
{
    using System;
    using System.Threading;

    class TimerMain
    {
        static void Main()
        {
            Timer tm = new Timer(10);

            tm.Methods += FirstToExecute;
            tm.Methods += SecondToExecute;

            tm.ExecuteMethod();
        }

        public static void FirstToExecute()
        {
            Console.WriteLine("I am the FIRST method");
        }

        public static void SecondToExecute()
        {
            Console.WriteLine("I am the SECOND method!");
        }
        
    }    

    // Using delegates write a class Timer that can execute certain method at each t seconds.
}
