using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GissaSiffranGrp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random randomGenerator = new Random();

            int correctNumber = randomGenerator.Next(1, 11);

            int guesses = 0;
            int guess = 0;


            while (guesses < 5 && guess != correctNumber)
            {
                guess = getGuess();

                guesses++;

                if(guess < correctNumber)
                {
                    Console.WriteLine("Gissa högre!");
                }
                else if (guess > correctNumber)
                {
                    Console.WriteLine("Gissa lägre!");
                }
                else
                {
                    Console.WriteLine("#WINNING");
                }
                
                Console.WriteLine("Gissningar: " + guesses);
            }

            if (guesses > 4)
            {
                Console.WriteLine("#LOSER");
            }

            Console.ReadLine();
        }

        static int getGuess()
        {
            Console.Write("Gissa en siffra mellan 1 och 10: ");

            string input = Console.ReadLine();

            return int.Parse(input);
        }

    }
}
