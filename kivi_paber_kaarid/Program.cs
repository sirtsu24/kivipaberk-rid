using System;

namespace kivi_paber_kaarid
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int userChoise;
            int cpuChoise;
            int userScore = 0;
            int cpuScore = 0;

            Console.WriteLine("Please insert your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");

            bool gameOver = false;

        Start:
            Random rnd = new Random();
            cpuChoise = rnd.Next(1, 4);

            while (!gameOver)
            {
                Console.WriteLine("Let's play a game! Choose 1 (scissors), 2 (paper) or 3 (rock).");
                userChoise = int.Parse(Console.ReadLine());

                if (userChoise == 1 || userChoise == 2 || userChoise == 3)
                {
                    if (userChoise == 1 && cpuChoise == 2)
                    {
                        userScore++;
                    }
                    else if (userChoise == 2 && cpuChoise == 3)
                    {
                        userScore++;
                    }
                    else if (userChoise == 3 && cpuChoise == 1)
                    {
                        userScore++;
                    }
                    else if (userChoise == cpuChoise)
                    {
                        Console.WriteLine("Tie!");
                    }
                    else
                    {
                        cpuScore++;
                    }

                    if (userScore == 3 || cpuScore == 3)
                    {

                        if (userScore == 3)
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("You Lose");
                        }
                        gameOver = true;

                    }

                    Console.WriteLine($"Your score is {userScore} and CPU score is {cpuScore}");
                }
                else
                {
                    Console.WriteLine("Insert 1, 2 or 3!");
                    goto Start;
                }
            }
        }
    }
}
