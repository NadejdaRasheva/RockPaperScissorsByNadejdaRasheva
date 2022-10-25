using System;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.Write("Choose [r]ock, [p]aper, [s]cissors: ");
            string playerMove = Console.ReadLine();

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = Rock;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = Paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = Scissors;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again...");
                return;
            }

            Random random = new Random();
            int compRandomNum = random.Next(1, 4);

            string compMove = "";

            switch (compRandomNum)
            {
                case 1:
                    compMove = Rock;
                    break;
                case 2:
                    compMove = Paper;
                    break;
                case 3:
                    compMove =  Scissors;
                    break;  
            }

            Console.WriteLine($"Computer chose {compMove}");

            if ((playerMove == Rock && compMove == Rock) || 
                (playerMove == Paper && compMove == Paper) || 
                (playerMove == Scissors && compMove == Scissors))
            {
                Console.WriteLine("This game was draw!");
            }
            else if ((playerMove == Rock && compMove == Paper) ||
                     (playerMove == Paper && compMove == Scissors) ||
                     (playerMove == Scissors && compMove == Rock))
            {
                Console.WriteLine("You Lose!");
            }
            else if ((playerMove == Rock && compMove == Scissors) ||
                     (playerMove == Paper && compMove == Rock) ||
                     (playerMove == Scissors && compMove == Paper))
            {
                Console.WriteLine("You win!");
            }
        }
    }
}
