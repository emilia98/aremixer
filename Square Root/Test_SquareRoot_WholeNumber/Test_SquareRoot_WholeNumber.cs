using System;
using System.Threading;
using System.Diagnostics;

namespace Test_SquareRoot_WholeNumber
{
    class Test_SquareRoot_WholeNumber
    {
        static void Main()
        {
            for (int index = 1; index <= 10; index++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Test {0}", index);
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Black;
                Random rnd = new Random();
                long number = rnd.Next(0, 100000000);
                Console.WriteLine("Number: {0}", number);

                // METHOD #1
                ExamineMethod1(number);
                // METHOD #2
                ExamineMethod2(number);
                //MATH.SQRT()
                ExamineMathSqrt(number);

                Thread.Sleep(500);
            }
        }

        static void ExamineMethod1(long number)
        {
            double p = number - 1;
            double y = 0;
            double q = 0;
            double p1 = 0;

            Console.ForegroundColor = ConsoleColor.Red;
            Stopwatch watch = new Stopwatch();

            watch.Start();

            if (p == 1)
            {
                y = 1;
            }
            else
            {
                while (true)
                {
                    q = number / p; ;
                    p1 = (q + p) / 2;

                    // Use Math.Abs() if needed
                    if (p - q <= 0.000001)
                    {
                        y = Math.Round(p, 5);
                        break;
                    }
                    p = p1;
                }
            }
            watch.Stop();

            TimeSpan time = watch.Elapsed;
            Console.WriteLine("Time Algo 1 : {0}", time);
            Console.WriteLine("Result Algo 1: {0}", y);
            watch.Reset();
            Console.ResetColor();
        }

        static void ExamineMethod2(long number)
        {

            Stopwatch watch = new Stopwatch();
            Console.ForegroundColor = ConsoleColor.Green;
            double x = 0;

            watch = new Stopwatch();
            watch.Start();

            x = number / 2;
            for (int i = 0; i < 20; i++)
            {
                x = (x + number / x) / 2d;
            }
            x = Math.Round(x, 5);
            watch.Stop();

            TimeSpan time = watch.Elapsed;
            Console.WriteLine("Time Algo 2 : {0}", time);
            Console.WriteLine("Result Algo 2: {0}", x);
            watch.Reset();
            Console.ResetColor();
        }

        static void ExamineMathSqrt(long number)
        {
            Stopwatch watch = new Stopwatch();

            watch = new Stopwatch();
            Console.ForegroundColor = ConsoleColor.Blue;

            watch.Start();
            double y = Math.Round(Math.Sqrt(number), 5);
            watch.Stop();

            TimeSpan time = watch.Elapsed;
            Console.WriteLine("Time Algo 3 : {0}", time);
            Console.WriteLine("Result Algo 3: {0}", y);
            Console.ResetColor();
        }
    }
}
