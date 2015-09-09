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

            writeCharArray(underscores);

            string guessTemp = Console.ReadLine();
            char guess = guessTemp[0];

            

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
