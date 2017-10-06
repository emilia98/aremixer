using System;
using System.Threading;

namespace Method_2_Examination
{
    class Method_2_Examination
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Whole Numbers");
            Console.ResetColor();

            for (int index = 0; index < 10; index++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Loop Number {0}", index);
                Console.ResetColor();

                Random rnd = new Random();
                long number = rnd.Next(0, 1000000000);
                Console.WriteLine("Number: {0}", number);
                double x = number / 2;

                for (int i = 0; i < 12; i++)
                {
                    x = (x + number / x) / 2d;
                }
                Console.WriteLine("Result 12 Loops: {0}", Math.Round(x, 5));

                for (int i = 0; i < 15; i++)
                {
                    x = (x + number / x) / 2d;
                }
                Console.WriteLine("Result 15 Loops: {0}", Math.Round(x, 5));

                for (int i = 0; i < 25; i++)
                {
                    x = (x + number / x) / 2d;
                }
                Console.WriteLine("Result 25 Loops: {0}", Math.Round(x, 5));

                x = number / 2;

                for (int i = 0; i < 50; i++)
                {
                    x = (x + number / x) / 2d;
                }
                Console.WriteLine("Result 50 Loops: {0}", Math.Round(x, 5));

                x = number / 2;

                for (int i = 0; i < 75; i++)
                {
                    x = (x + number / x) / 2d;
                }
                Console.WriteLine("Result 75 Loops: {0}", Math.Round(x, 5));

                x = number / 2;

                for (int i = 0; i < 100; i++)
                {
                    x = (x + number / x) / 2d;
                }
                Console.WriteLine("Result 100 Loops: {0}", Math.Round(x, 5));

                Console.WriteLine("ORIGINAL: {0}", Math.Round(Math.Sqrt(number), 5));

                Thread.Sleep(500);
            }

            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Floating Point Numbers");
            Console.ResetColor();

            for (int index = 0; index < 10; index++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Loop Number {0}", index);
                Console.ResetColor();

                Random rnd = new Random();
                double number = rnd.NextDouble();
                number *= 1000000;
                Console.WriteLine("Number: {0}", number);
                
                double x = number / 2;

                for (int i = 0; i < 12; i++)
                {
                    x = (x + number / x) / 2d;
                }
                Console.WriteLine("Result 12 Loops: {0}", Math.Round(x, 5));

                for (int i = 0; i < 15; i++)
                {
                    x = (x + number / x) / 2d;
                }
                Console.WriteLine("Result 12 Loops: {0}", Math.Round(x, 5));

                for (int i = 0; i < 25; i++)
                {
                    x = (x + number / x) / 2d;
                }
                Console.WriteLine("Result 25 Loops: {0}", Math.Round(x, 5));

                x = number / 2;

                for (int i = 0; i < 50; i++)
                {
                    x = (x + number / x) / 2d;
                }
                Console.WriteLine("Result 50 Loops: {0}", Math.Round(x, 5));

                x = number / 2;

                for (int i = 0; i < 75; i++)
                {
                    x = (x + number / x) / 2d;
                }
                Console.WriteLine("Result 75 Loops: {0}", Math.Round(x, 5));

                x = number / 2;

                for (int i = 0; i < 100; i++)
                {
                    x = (x + number / x) / 2d;
                }
                Console.WriteLine("Result 100 Loops: {0}", Math.Round(x, 5));

                Console.WriteLine("ORIGINAL: {0}", Math.Round(Math.Sqrt(number), 5));

                Thread.Sleep(500);
            }
        }
    }
}
