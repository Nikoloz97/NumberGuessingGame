namespace GuessNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int UserDifficultyLevel;



            Console.WriteLine("Choose a difficulty level (1-3): ");
            UserDifficultyLevel = Convert.ToInt32(Console.ReadLine());

            while (UserDifficultyLevel != 1 && UserDifficultyLevel != 2 && UserDifficultyLevel != 3)
            {
                Console.WriteLine("Not a valid response. Try again: ");
                UserDifficultyLevel = Convert.ToInt32(Console.ReadLine());
            }


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