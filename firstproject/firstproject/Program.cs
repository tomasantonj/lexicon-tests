using System;
namespace FizzBuzzOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create lists to hold test data
            List<int> numbers = new List<int>();
            List<int> testOne = new List<int>();
            List<int> testTwo = new List<int>();
            List<int> testThree = new List<int>();

            // Add test data to numbers and run test one
            testOne.Add(2);
            testOne.Add(3);
            testOne.Add(7);
            numbers.AddRange(testOne); 
            Console.WriteLine("Test One:");
            for (int i = 1; i <= numbers[2]; i++)
                {
                    if (i % numbers[0] == 0 && i % numbers[1] == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % numbers[1] == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (i % numbers[0] == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                } 

            numbers.Clear(); // Clear the list to reuse it for the next test
            // Add test data to numbers and run test two
            testTwo.Add(2);
            testTwo.Add(4);
            testTwo.Add(7);
            numbers.AddRange(testTwo); 
            Console.WriteLine("Test Two:");
            for (int i = 1; i <= numbers[2]; i++)
                {
                    if (i % numbers[0] == 0 && i % numbers[1] == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % numbers[1] == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (i % numbers[0] == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                } 
            
            numbers.Clear(); // Clear the list to reuse it for the next test
            // Add test data to numbers and run test three
            testThree.Add(3);
            testThree.Add(5);
            testThree.Add(7);
            numbers.AddRange(testThree); 
            Console.WriteLine("Test Three:");
            for (int i = 1; i <= numbers[2]; i++)
                {
                    if (i % numbers[0] == 0 && i % numbers[1] == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % numbers[1] == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (i % numbers[0] == 0)
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