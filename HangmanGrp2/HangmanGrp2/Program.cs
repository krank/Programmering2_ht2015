using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGrp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string correctWord = randomWord();

            char[] underscores = new char[correctWord.Length];

            for (int i = 0; i < underscores.Length; i++)
            {
                underscores[i] = '_';
            }

            List<char> incorrectGuesses = new List<char>();

            while (underscores.Contains<char>('_') && incorrectGuesses.Count < 11)
            {
                writeCharArray(underscores);

                writeCharArray(incorrectGuesses.ToArray());

                string guessTemp = "";
                while (guessTemp.Length == 0) {
                    Console.Write("Gissa på en bokstav: ");
                    guessTemp = Console.ReadLine();
                }

                guessTemp = guessTemp.ToLower();
                
                char guess = guessTemp[0];
                

                bool hasMatched = false;

                for (int i=0; i < correctWord.Length; i++)
                {
                    if (correctWord[i] == guess)
                    {
                        underscores[i] = correctWord[i];
                        hasMatched = true;
                    }
                }

                if (!hasMatched)
                {
                    Console.WriteLine("NO U NOOB");
                    incorrectGuesses.Add(guess);
                }

            }

            writeCharArray(underscores);

            if(incorrectGuesses.Count < 11)
            {
                Console.WriteLine("#WINNING");
            }
            else
            {
                Console.WriteLine("#LOSER");
            }

            Console.ReadLine();
        }

        static void writeCharArray(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static string randomWord()
        {
            string[] words = new string[] { "skit", "på", "dig", "grunkifjonk", "facebook", "flaggstångsknoppsmålarlärlingsmössa" };

            Random generator = new Random();

            int randomIndex = generator.Next(words.Length);

            return words[randomIndex];

        }

    }
}
