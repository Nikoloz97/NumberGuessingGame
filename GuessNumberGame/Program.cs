namespace GuessNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int UserDifficultyLevel;

            // TODO: Fix this issue...

    /*        // Stuck in do-while even if user selects 1, 2, or 3...
            do
            {
                if (UserDifficultyLevel != "1" || UserDifficultyLevel != "2" || UserDifficultyLevel != "3")
                {
                    Console.WriteLine("Try again. Invalid response");
                }
                // Prompt difficulty level 
                Console.WriteLine("Please select a difficulty level from 1-3: ");
                UserDifficultyLevel = Console.ReadLine();

            } while (UserDifficultyLevel != "1" || UserDifficultyLevel != "2" || UserDifficultyLevel != "3");*/




            Console.WriteLine("Choose a difficulty level");
            UserDifficultyLevel = Convert.ToInt32(Console.ReadLine());


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
    }
}