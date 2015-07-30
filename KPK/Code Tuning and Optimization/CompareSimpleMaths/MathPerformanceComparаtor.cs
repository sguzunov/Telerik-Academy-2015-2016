namespace CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    public class MathPerformanceComparаtor
    {
        private const int NUMBER_OF_TEST_TIMES = 5;
        private const int NUMBER_OF_OPERATIONS = 1000000;

        private Stopwatch watch = new Stopwatch();

        public void TestPerformance(Operations operation)
        {
            for (int times = 0; times < NUMBER_OF_TEST_TIMES; times++)
            {
                Console.WriteLine("-----------Test: {0}----------", times + 1);

                this.watch.Start();
                this.TestInteger(operation);
                this.watch.Stop();
                Console.WriteLine("Int time: {0}", this.watch.Elapsed);
                this.watch.Reset();

                this.watch.Start();
                this.TestLong(operation);
                this.watch.Stop();
                Console.WriteLine("Long time: {0}", this.watch.Elapsed);
                this.watch.Reset();

                this.watch.Start();
                this.TestFloat(operation);
                this.watch.Stop();
                Console.WriteLine("Float time: {0}", this.watch.Elapsed);
                this.watch.Reset();

                this.watch.Start();
                this.TestDouble(operation);
                this.watch.Stop();
                Console.WriteLine("Double time: {0}", this.watch.Elapsed);
                this.watch.Reset();

                this.watch.Start();
                this.TestDecimal(operation);
                this.watch.Stop();
                Console.WriteLine("Decimal time: {0}", this.watch.Elapsed);
                this.watch.Reset();
            }
        }

        private void TestInteger(Operations operation)
        {
            int number = 1;
            for (int i = 0; i < NUMBER_OF_OPERATIONS; i++)
            {
                if (Operations.Addition == operation)
                {
                    number += 1;
                }
                else if (Operations.Subtraction == operation)
                {
                    number -= 1;
                }
                else if (Operations.Multiplication == operation)
                {
                    number *= 1;
                }
                else if (Operations.Division == operation)
                {
                    number /= 1;
                }
                else if (Operations.Incrementation == operation)
                {
                    number++;
                }
            }
        }

        private void TestLong(Operations operation)
        {
            long number = 1;
            for (int i = 0; i < NUMBER_OF_OPERATIONS; i++)
            {
                if (Operations.Addition == operation)
                {
                    number += 1L;
                }
                else if (Operations.Subtraction == operation)
                {
                    number -= 1L;
                }
                else if (Operations.Multiplication == operation)
                {
                    number *= 1L;
                }
                else if (Operations.Division == operation)
                {
                    number /= 1L;
                }
                else if (Operations.Incrementation == operation)
                {
                    number++;
                }
            }
        }

        private void TestFloat(Operations operation)
        {
            float number = 1F;
            for (int i = 0; i < NUMBER_OF_OPERATIONS; i++)
            {
                if (Operations.Addition == operation)
                {
                    number += 1F;
                }
                else if (Operations.Subtraction == operation)
                {
                    number -= 1F;
                }
                else if (Operations.Multiplication == operation)
                {
                    number *= 1F;
                }
                else if (Operations.Division == operation)
                {
                    number /= 1F;
                }
                else if (Operations.Incrementation == operation)
                {
                    number++;
                }
            }
        }

        private void TestDouble(Operations operation)
        {
            double number = 1.0;
            for (int i = 0; i < NUMBER_OF_OPERATIONS; i++)
            {
                if (Operations.Addition == operation)
                {
                    number += 1.0;
                }
                else if (Operations.Subtraction == operation)
                {
                    number -= 1.0;
                }
                else if (Operations.Multiplication == operation)
                {
                    number *= 1.0;
                }
                else if (Operations.Division == operation)
                {
                    number /= 1.0;
                }
                else if (Operations.Incrementation == operation)
                {
                    number++;
                }
            }
        }

        private void TestDecimal(Operations operation)
        {
            decimal number = 1.0M;
            for (int i = 0; i < NUMBER_OF_OPERATIONS; i++)
            {
                if (Operations.Addition == operation)
                {
                    number += 1.0M;
                }
                else if (Operations.Subtraction == operation)
                {
                    number -= 1.0M;
                }
                else if (Operations.Multiplication == operation)
                {
                    number *= 1.0M;
                }
                else if (Operations.Division == operation)
                {
                    number /= 1.0M;
                }
                else if (Operations.Incrementation == operation)
                {
                    number++;
                }
            }
        }
    }
}
