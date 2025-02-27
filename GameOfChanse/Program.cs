using System;

class GameOfChance
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            Console.WriteLine("Rolling three dice...");

            int die1 = random.Next(1, 7);  // Roll first die (1-6)
            int die2 = random.Next(1, 7);  // Roll second die (1-6)
            int die3 = random.Next(1, 7);  // Roll third die (1-6)

            int sum = die1 + die2 + die3;

            Console.WriteLine($"You rolled: {die1}, {die2}, {die3}");
            Console.WriteLine($"Total sum: {sum}");

            if (sum == 18)
            {
                Console.WriteLine("Congratulations! You hit 18!");
            }
            else
            {
                Console.WriteLine("Sorry, you didn't hit 18.");
            }

            Console.WriteLine("Do you want to play again? (y/n)");
            string response = Console.ReadLine().ToLower();

            if (response != "y")
            {
                playAgain = false;
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}