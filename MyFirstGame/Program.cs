using System;

namespace MyFirstGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int playerChoice, gamesCount;

            Console.Write("Enter games count: ");
            gamesCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < gamesCount; i++)
            {
                Console.Write("\nEnter your choice: 1 to stone, 2 to scissors, 3 to paper. Your choise: ");

                playerChoice = Convert.ToInt32(Console.ReadLine());

                int compChoice = random.Next(1, 3);
                Console.WriteLine($"\nComp choice = {compChoice}\n");
                Console.WriteLine(ChekGameResult(playerChoice, compChoice));

                Console.ReadKey();
            }
        }
        private static string ChekGameResult(int firstChoice, int secondChoice)
        {
            if ((firstChoice == 1 && secondChoice == 2)
                || (firstChoice == 2 && secondChoice == 3)
                || (firstChoice == 3 && secondChoice == 1))
            {
                return "Player win.";
            }
            else if (firstChoice == secondChoice)
            {
                return "Draw.";
            }
            else
            {
                return "Player lose";
            }
        }
    }
}