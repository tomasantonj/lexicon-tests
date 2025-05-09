using System;
namespace FizzBuzzTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Input 3 numbers to test, separate by commas:");
            // Read input from the user
            // Example input: 2,3,7
            string input = Console.ReadLine();
            string[] inputNumbers = input.Split(',');

            // convert input strings to integers
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (int.TryParse(inputNumbers[i], out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine($"Invalid input: {inputNumbers[i]} is not a number.");
                    return;
                }
            }

            // Make sure that input is valid with basic checks
            if (inputNumbers.Length == 0)
            {
                Console.WriteLine("No input provided.");
                return;
            }
            if (inputNumbers.Length > 3)
            {
                Console.WriteLine("Please enter no more than 3 numbers.");
                return;
            }
            if (inputNumbers.Length != 3)
            {
                Console.WriteLine("Please enter exactly 3 numbers.");
                return;
            }

            // Display to verify the input numbers
            foreach (var number in numbers)
            {
                Console.WriteLine("Number: " + number );
            }

            // Run the FizzBuzz logic
            Console.WriteLine("Running inputted numbers through FizzBuzz:");
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