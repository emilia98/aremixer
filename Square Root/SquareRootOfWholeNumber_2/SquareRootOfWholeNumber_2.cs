using System;

namespace SquareRootOfWholeNumber_2
{
    class SquareRootOfWholeNumber_2
    {
        static void Main()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 1000000);
            Console.WriteLine("Number: {0}", number);
            double x = number / 2;

            for (int i = 0; i < 20; i++)
            {
                x = (x + number / x) / 2;
            }
            Console.WriteLine("Result: {0}", Math.Round(x, 5));
        }
    }
}
