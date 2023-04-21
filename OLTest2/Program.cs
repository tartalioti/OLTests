using System;

namespace OLTest2
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine()!;

            if (int.TryParse(input, out int number))
            {
                string binary = Convert.ToString(number, 2);
                Console.WriteLine($"The number  {number} in binary is: {binary}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}