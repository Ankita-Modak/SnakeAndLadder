using System;

namespace SnakeLadder
{

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

                position += dice;

                if (position > 100)
                {
                    position = 100 - (position - 100);
                }

                Console.WriteLine("You are now at position {0}", position);

                switch (position)
                {
                    case 3:
                        Console.WriteLine("You landed on a ladder! Moving up to position 21");
                        position = 21;
                        break;
                    case 8:
                        Console.WriteLine("You landed on a snake! Moving down to position 4");
                        position = 4;
                        break;
                    case 28:
                        Console.WriteLine("You landed on a ladder! Moving up to position 84");
                        position = 84;
                        break;
                    case 58:
                        Console.WriteLine("You landed on a snake! Moving down to position 36");
                        position = 36;
                        break;
                    case 75:
                        Console.WriteLine("You landed on a ladder! Moving up to position 91");
                        position = 91;
                        break;
                    case 88:
                        Console.WriteLine("You landed on a snake! Moving down to position 24");
                        position = 24;
                        break;
                }
            }

            Console.WriteLine("Congratulations, you won the game!");
        }
    }

}
