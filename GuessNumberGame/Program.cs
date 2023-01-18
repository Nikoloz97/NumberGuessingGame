namespace GuessNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UserDifficultyLevel;

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
            UserDifficultyLevel = Console.ReadLine();


            // Level 1 = 1 - 10

            if (UserDifficultyLevel == "1")
            {

            int RandomNumb = new Random().Next(1, 11);
            Console.WriteLine("I have my number. What's your guess?");
            int UserInput = Convert.ToInt32(Console.ReadLine());

                while (UserInput != RandomNumb)
                {

                }

                Console.WriteLine("You got it! The correct answer was: " + RandomNumb);
                


            }

            // Level 2 = 1 - 100

            else if (UserDifficultyLevel == "2")
            {
                int RandomNumb = new Random().Next(1, 101);
                Console.WriteLine("I have my number. What's your guess?");
                int UserInput = Convert.ToInt32(Console.ReadLine());

                while (UserInput != RandomNumb)
                {

                }

                Console.WriteLine("You got it! The correct answer was: " + RandomNumb);
            }

            // Level 3 = 1 - 1000

            else if (UserDifficultyLevel == "3")
            {
                int RandomNumb = new Random().Next(1, 1001);
                Console.WriteLine("I have my number. What's your guess?");
                int UserInput = Convert.ToInt32(Console.ReadLine());

                while (UserInput != RandomNumb)
                {

                }

                Console.WriteLine("You got it! The correct answer was: " + RandomNumb);
            }

            


            
            
            



        }
    }
}