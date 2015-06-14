namespace TimeSpace
{
    using System;
    using System.Threading;

    public delegate void TimerDelegate();

    public class Timer
    {
        public TimerDelegate Methods;
        private int interval;

        public Timer(int interval)
        {
            this.Interval = interval;
        }

        public int Interval
        {
            get 
            {
                return this.interval;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Incorrect input data!");
                }

                this.interval = value;
            }
        }

        public void ExecuteMethod()
        {
            while (true)
            {
                this.Methods();
                Thread.Sleep(this.Interval * 1000);
            }
        }        
    }
}
