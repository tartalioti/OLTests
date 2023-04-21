using System;

namespace OLTest1
{
    static class Program
    {
        static void Main(string[] args)
        {
            string Username = "atmiskampoti";
            string Password = "atmiskampoti123";
            int attempts = 5;

            for (int i = 0; i < attempts; i++)
            {
                Console.Write("Enter username: ");
                string inputname = Console.ReadLine()!;

                Console.Write("Enter password: ");
                string inputPassword = Console.ReadLine()!;

                if (inputname == Username && inputPassword == Password)
                {
                    Console.WriteLine("Success!");
                    break;
                }
                else
                {
                    int remainingAttempts = attempts - i - 1;
                    if (remainingAttempts > 0)
                    {
                        Console.WriteLine($"Incorrect username or password. You have {remainingAttempts} attempts left.");
                    }
                    else
                    {
                        Console.WriteLine("Error: Too many incorrect attempts.");
                    }
                }
            }
        }
    }
}