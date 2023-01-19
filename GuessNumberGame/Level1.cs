using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame
{
    public class Level1
    {
        public static void LevelOnePrompt() {

            int RandomNumb = new Random().Next(1, 11);
            Console.WriteLine("I have my number. What's your guess?");
            int UserInput = Convert.ToInt32(Console.ReadLine());

            int NumberOfGuesses = 1;

            while (UserInput != RandomNumb)
            {
                NumberOfGuesses++;

                if (UserInput > RandomNumb)
                {
                    Console.WriteLine("Too high! Try again: ");
                    UserInput = Convert.ToInt32(Console.ReadLine());
                }

                else
                {
                    Console.WriteLine("Too low! Try again: ");
                    UserInput = Convert.ToInt32(Console.ReadLine());
                }

            }

            Console.WriteLine($"You got it in {NumberOfGuesses} attempts ! My number was: " + RandomNumb);

        }


    }
}
