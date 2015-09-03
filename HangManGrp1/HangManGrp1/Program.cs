using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManGrp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Skapa variabeln correctWord och tilldela den ett slumpmässigt ord som genereras av metoden randomWord
            string correctWord = randomWord();

            // Skapa variabeln underscores; det är en array med char-värden i. Dess innehåll genereras av metoden makeUnderscores.
            // makeUnderscores tar emot antalet understreck som ska läggas till i arrayen.
            char[] underscores = makeUnderscores(correctWord.Length);

            List<char> wrongLetters = new List<char>();

            while (wrongLetters.Count <= 6) { 

                // Skriv ut underscores
                writeArray(underscores);

                // Läs in en string med ReadLine och ta första tecknet i den stringen, alltså [0], och spara som guess
                char guess = Console.ReadLine()[0];

                List<int> positions = findPositions(guess, correctWord);

                if (positions.Count == 0)
                {
                    wrongLetters.Add(guess);
                    Console.WriteLine("FEL!");
                }
                else
                {
                    Console.WriteLine("RÄTT!");

                    for (int i=0; i< positions.Count; i++)
                    {
                        int pos = positions[i];

                        underscores[pos] = guess;

                    }


                }

            }

            Console.WriteLine("Spelet är slut!");

            // Vänta på att spelaren trycker Enter innan spelet avslutas och fönstret stängs
            Console.ReadLine();

        }

        // Metod för att generera slumpade ord
        static string randomWord()
        {
            // Skapa en ny slumpgenerator
            Random randomGenerator = new Random();

            // Skapa en lista med ord
            string[] words = new string[3] { "memes", "gobank", "jultomten" };

            // Slumpa ett tal mellan 0 och längden på ordlistan. OBS! Kan bli 0, men aldrig maxvärdet (längden på listan)
            int wordIndex = randomGenerator.Next(words.Length);

            // Returnera det ord som finns på den framslumpade positionen
            return words[wordIndex];
        }

        // Metod för att skapa en char-array med understreck
        static char[] makeUnderscores(int length)
        {
            // Skapa en char-array av angiven längd
            char[] underscores = new char[length];

            // Kör en loop lika många gånger som listan ska innehålla understreck
            for (int i = 0; i < length; i++)
            {
                // Skriv in ett understreck i char-arrayen på den plats positionen motsvarar
                underscores[i] = '_';
            }

            // Returnera den färdiga char-arrayen
            return underscores;
        }

        // Metod för att skriva ut en array
        static void writeArray(char[] array)
        {
            // Kör en loop lika många gånger som det finns chars i arrayen
            for (int i = 0; i < array.Length; i++)
            {
                // Skriv ut den char som befinner sig på motsvarande position, plus ett mellanslag.
                Console.Write(array[i] + " ");
            }

            // Skriv ut en radbrytning.
            Console.WriteLine();
        }

        static List<int> findPositions(char letter, string word)
        {
            // Skapa en lista som ska innehålla de positioner den gissade bokstaven finns på.
            // Till exempel 1 och 3 om ordet är "banan" och den gissade bokstaven är "a".
            List<int> positions = new List<int>();

            // Gå igenom det korrekta ordet, och jämför varje bokstav i det med den bokstav spelaren gissade på
            for (int i = 0; i < word.Length; i++)
            {
                
                if (letter == word[i])
                {
                    // Om bokstaven matchar, spara dess position
                    positions.Add(i);
                }
            }

            return positions;


        }

    }
}
