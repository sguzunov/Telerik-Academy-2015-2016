namespace CompareAdvancedMath
{
    using System;
    using System.Diagnostics;

    public class MathPerformanceComperator
    {
        private const int NUMBER_OF_TEST_TIMES = 5;
        private const int NUMBER_OF_OPERATIONS = 1000000;

        private Stopwatch watch = new Stopwatch();

        public void TestPerformance(Functions func)
        {
            for (int times = 0; times < NUMBER_OF_TEST_TIMES; times++)
            {
                Console.WriteLine("-----------Test: {0}----------", times + 1);

                this.watch.Start();
                this.TestFloat(func);
                this.watch.Stop();
                Console.WriteLine("Float time: {0}", this.watch.Elapsed);
                this.watch.Reset();

                this.watch.Start();
                this.TestDouble(func);
                this.watch.Stop();
                Console.WriteLine("Double time: {0}", this.watch.Elapsed);
                this.watch.Reset();

                this.watch.Start();
                this.TestDecimal(func);
                this.watch.Stop();
                Console.WriteLine("Decimal time: {0}", this.watch.Elapsed);
                this.watch.Reset();
            }
        }

        private void TestDecimal(Functions func)
        {
            decimal result = 1.0M;
            decimal value = 1.0M;
            for (int i = 1; i < NUMBER_OF_OPERATIONS; i++)
            {
                if (Functions.Sqrt == func)
                {
                    result = (decimal)Math.Sqrt((double)value);
                }
                else if (Functions.Sin == func)
                {
                    result = (decimal)Math.Sin((double)value);
                }
                else if (Functions.log == func)
                {
                    result = (decimal)Math.Log((double)value);
                }
            }
        }

        private void TestDouble(Functions func)
        {
            double result = 1;
            double value = 1;
            for (int i = 1; i < NUMBER_OF_OPERATIONS; i++)
            {
                if (Functions.Sqrt == func)
                {
                    result = Math.Sqrt(value);
                }
                else if (Functions.Sin == func)
                {
                    result = Math.Sin(value);
                }
                else if (Functions.log == func)
                {
                    result = Math.Log(value);
                }
            }
        }

        private void TestFloat(Functions func)
        {
            float result = 1.0F;
            float value = 1.0F;
            for (int i = 1; i < NUMBER_OF_OPERATIONS; i++)
            {
                if (Functions.Sqrt == func)
                {
                    result = (float)Math.Sqrt((double)value);
                }
                else if (Functions.Sin == func)
                {
                    result = (float)Math.Sin((double)value);
                }
                else if (Functions.log == func)
                {
                    result = (float)Math.Log((double)value);
                }
            }
        }
    }
}
