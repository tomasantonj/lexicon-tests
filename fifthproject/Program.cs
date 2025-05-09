using System;

namespace FizzBuzzFive {
    class Program {
        static void Main(string[] args) { 
            // Take the data from GenerateData and split it into 3 ints, x y n and pass them to the FizzBuzz function
            string[] numbers = GenerateData().Split(',');
            int x = int.Parse(numbers[0]);
            int y = int.Parse(numbers[1]);
            int n = int.Parse(numbers[2]);
            // input data into FizzBuzz function
            FizzBuzz(x, y, n);
        }
        // FizzBuzz logic takes 3 ints x, y & n, checks if they are divisible by x, y or both and outputs the result to the console
        private static string FizzBuzz(int x, int y, int n) {
            // Output the numbers in fizzbuzz logic for verification
            // Console.WriteLine($"x: {x}, y: {y}, n: {n}");            
            Console.WriteLine("Running FizzBuzz logic ...");
            // output the numbers to be used in the FizzBuzz logic
            string message = string.Empty;
            for (int i = 1; i <= n; i++) {
                if (i % x == 0 && i % y == 0) {
                    OutputData(message="FizzBuzz");
                }
                else if (i % y == 0) {
                    OutputData(message="Buzz");
                }
                else if (i % x == 0) {
                    OutputData(message="Fizz");
                }
                else {
                    OutputData(message=i.ToString());
                }
            }
            OutputData(message="FizzBuzz logic completed.");
            return message;
        }
        // Simple function to output data to the console, reusable for any string data
        private static void OutputData(string message) {
            Console.WriteLine(message);
        }
        // Function to generate 3 random numbers to be used in the FizzBuzz logic
        private static string GenerateData() {
            // create a new instance of the Random class to generate random numbers
            Random random = new Random();
            int x = random.Next(2, 10); // Random number between 2 and 9
            int y = random.Next(2, 10); // Random number between 2 and 9
            // check if either x or y is even, if not, generate a new number
            // No other reason that it makes for a more interesting game
            while (x % 2 != 0 && y % 2 != 0) {
                x = random.Next(2, 10);
                y = random.Next(2, 10);
            }
            // make sure that y is greater than x and not the same as x, if so generate a new number for y
            while (y < x) {
                y = random.Next(2, 10);
            }
            // check if x and y are the same if so genereate a new number for y
            // Again, only to make it more interesting
            while (x == y) {
                y = random.Next(2, 10);
            }
            int n = random.Next(1, 100); // Random number between 1 and 99
            // make sure that n is greater than x and y and not the same as x or y, if so generate a new number for n
            while (n < x || n < y) {
                n = random.Next(1, 100);
            }
            Console.WriteLine($"Generated numbers: {x}, {y}, {n}");
            return $"{x},{y},{n}";
        }
    }   
}