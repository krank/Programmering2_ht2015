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

            string correctWord = "krank";

            char[] underscores = new char[correctWord.Length];

            for (int i = 0; i < underscores.Length; i++)
            {
                underscores[i] = '_';
            }

            while ( underscores.Contains<char>('_') ) { 
                writeCharArray(underscores);

                string guessTemp = Console.ReadLine();
                char guess = guessTemp[0];
            
                for (int i=0; i < correctWord.Length; i++)
                {
                    if (correctWord[i] == guess)
                    {
                        underscores[i] = correctWord[i];
                    }
                }
            }

            writeCharArray(underscores);

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

    }
}
