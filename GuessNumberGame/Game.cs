using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame
{
    public class Game
    {
        public int UserDifficultyLevel { get; set; } = 0;

        public void Run()
        {

            Console.WriteLine("Choose a difficulty level (1-3): ");
            ChooseDifficulty(Convert.ToInt32(Console.ReadLine()));


            // Level 1 = 1 - 10

            if (UserDifficultyLevel == 1)
            {
                Level1.LevelOnePrompt();
            }

            // Level 2 = 1 - 100

            else if (UserDifficultyLevel == 2)
            {
                Level2.LevelTwoPrompt();
            }

            // Level 3 = 1 - 1000

            else if (UserDifficultyLevel == 3)
            {
                Level3.LevelThreePrompt();
            }

        }






        public void ChooseDifficulty (int choice)
        {

           

            while (UserDifficultyLevel != 1 && UserDifficultyLevel != 2 && UserDifficultyLevel != 3)
            {
                Console.WriteLine("Not a valid response. Try again: ");
                UserDifficultyLevel = Convert.ToInt32(Console.ReadLine());
            }

        }

    }

     
}
