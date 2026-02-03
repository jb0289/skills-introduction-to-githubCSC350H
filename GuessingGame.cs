using System;

class GuessingGame
{
    static void Main()
    {
        Console.WriteLine("====================================");
        Console.WriteLine("  Guess a number between 1 and 25:  ");
        Console.WriteLine("====================================");

        Console.Write("Enter your 1st integer (a): ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter your 2nd integer (b): ");
        int b = int.Parse(Console.ReadLine());

        int num1 = Math.Min(a, b);
        int num2 = Math.Max(a, b);

        Random random = new Random();
        int number = random.Next(num1, num2 + 1);

        Console.WriteLine("What is the number I'm thinking of between " + num1 + " and " + num2 + "?");
        Console.WriteLine("You have 5 guesses.... ");

        for (int attempt = 1; attempt <= 5; attempt++)
        {
            Console.Write($"Guess #{attempt}: ");
            int guess = int.Parse(Console.ReadLine());

            if (guess == number)
            {
                Console.WriteLine($"\nYou must be psychic! The number was {number}.");
                return;
            }
            else if (guess < number)
            {
                Console.WriteLine("The number is bigger!");
            }
            else
            {
                Console.WriteLine("The number is smaller!");
            }
        }

        // If all guesses are exhausted
        Console.WriteLine($"\nSorry.... you've run out of guesses. The number was {number}.");
    }}