using System;

namespace FizzBuzzFour
{
    class Program
    {
        static void Main(string[] args)
        { 
            OutputData(FizzBuzz(2,3,7));
        }

        private static string FizzBuzz(int x, int y, int n)
        {
            Console.WriteLine("Running FizzBuzz logic ...");
            string message = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                if (i % x == 0 && i % y == 0)
                {
                    message = "FizzBuzz";
                    OutputData(message);
                }
                else if (i % y == 0)
                {
                    message = "Buzz";
                    OutputData(message);
                }
                else if (i % x == 0)
                {
                    message = "Fizz";
                    OutputData(message);
                }
                else
                {
                    message = i.ToString();
                    OutputData(message);
                }
            }
            return "FizzBuzz logic completed.";
        }

        private static void OutputData(string message)
        {
            Console.WriteLine(message);
        }
    }   
}