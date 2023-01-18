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

            while (UserInput != RandomNumb)
            {
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

            Console.WriteLine("You got it! The correct answer was: " + RandomNumb);

        }


    }
}
