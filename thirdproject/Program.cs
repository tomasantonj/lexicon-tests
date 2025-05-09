using System;

namespace FizzBuzzThree
{
    class Program
    {
        static void Main(string[] args)
        { 
            FizzBuzz(2, 3, 7);
        }

        private static void FizzBuzz(int x, int y, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % x == 0 && i % y == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % y == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % x == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        
    }   
}