using System;

namespace SquareRootOfFloatingPoint_2
{
    class SquareRootOfFloatingPoint_2
    {
        static void Main()
        {
            Random rnd = new Random();
            double number = rnd.NextDouble();
            number *= 1000000;
            Console.WriteLine("Number: {0}", number);
            double x = number / 2;

            for (int i = 0; i < 100; i++)
            {
                x = (x + number / x) / 2d;
            }
            Console.WriteLine("Result: {0}", Math.Round(x, 5));
        }
    }
}
