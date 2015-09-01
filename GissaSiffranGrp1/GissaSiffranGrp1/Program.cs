using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GissaSiffranGrp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int correct;
            int guess = 0;
            int countGuesses = 1;

            Random randomGenerator = new Random();

            correct = randomGenerator.Next(1, 11);

            while (guess != correct && countGuesses < 3) {
                Console.Write("Skriv ett tal mellan 1 och 10: ");
                guess = int.Parse(Console.ReadLine());
                countGuesses++;

                if (guess > correct)
                {
                    Console.WriteLine("För högt!");
                }
                else if (guess < correct)
                {
                    Console.WriteLine("För lågt!");
                } else
                {
                    Console.WriteLine("#winning");
                }
            }


            Console.ReadLine();

        }
    }
}
