using System;

namespace SnakeLadder;
class SnakeAndLadder
{
    static void Main(string[] args)
    {
        int position = 0;
        Console.WriteLine("Welcome to the Snake and Ladder game!");

        while (position < 100)
        {
            Console.WriteLine("Press any key to roll the dice");
            Console.ReadKey(true);

            Random random = new Random();
            int dice = random.Next(1, 7);

            Console.WriteLine("You rolled a {0}", dice);

            int option = random.Next(0, 3);
            switch (option)
            {
                case 0:
                    Console.WriteLine("No Play. You stay at position {0}", position);
                    break;
                case 1:
                    position += dice;
                    if (position > 100)
                    {
                        position = 100 - (position - 100);
                    }
                    Console.WriteLine("You landed on a ladder! Moving up to position {0}", position);
                    break;
                case 2:
                    position -= dice;
                    if (position < 0)
                    {
                        position = 0;
                    }
                    Console.WriteLine("You landed on a snake! Moving down to position {0}", position);
                    break;
            }

            if (position == 100)
            {
                break;
            }

            Console.WriteLine("You are now at position {0}", position);
        }

        Console.WriteLine("Congratulations, you won the game!");
    }
}
