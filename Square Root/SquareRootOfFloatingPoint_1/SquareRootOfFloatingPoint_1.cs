using System;

namespace SquareRootOfFloatingPoint_1
{
    class SquareRootOfFloatingPoint_1
    {
        static void Main()
        {
            Random rnd = new Random();
            double x = rnd.NextDouble();
            x *= 1000000;
            Console.WriteLine("Number: {0}", x);

            double p = x - 1;
            double y = 0;
            double q = 0;
            double p1 = 0;

            if (p == 0)
            {
                y = 1;
            }
            else
            {
                while (true)
                {
                    q = x / p;
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
            Console.WriteLine("Result = {0}", y);
        }
    }
}
