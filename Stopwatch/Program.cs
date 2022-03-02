// See https://aka.ms/new-console-template for more information


using System;

namespace Stopwatch // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            string Input;
            var Timer = new Stopwatch();

            Console.WriteLine("Enter S to start the stopwatch and Q to stop.");
            Input = Console.ReadLine();

            while (!string.IsNullOrEmpty(Input))
            {
                if (string.Equals("s", Input) || string.Equals("S", Input))
                {
                    Timer.Start();
                    Console.WriteLine("Enter Q to stop the stopwatch.");
                }
                else if (string.Equals("q", Input, StringComparison.CurrentCultureIgnoreCase))
                {
                    Timer.Stop();
                    Console.WriteLine("Enter S to start the stopwatch.");
                }

                Input = Console.ReadLine();
            }




            SByte

        }
    }
}