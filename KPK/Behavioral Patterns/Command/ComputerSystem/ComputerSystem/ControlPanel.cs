namespace ComputerSystem
{
    using System;
    using System.Threading;

    public class ControlPanel
    {
        public void Restart()
        {
            Console.WriteLine("OS is shutting down.");
            Thread.Sleep(2000);
            Console.WriteLine("OS is loading.");
        }

        public void ShutDown()
        {
            Console.WriteLine("OS is shutting down.");
        }

        public void Sleep()
        {
            Console.WriteLine("OS is shutting down.");
            Thread.Sleep(10000);
        }
    }
}
