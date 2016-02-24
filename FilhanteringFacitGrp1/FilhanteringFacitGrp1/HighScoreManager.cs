using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilhanteringFacitGrp1
{
    class HighScoreManager
    {

        private List<string> scores = new List<string>();

        public void LoadFromFile()
        {
            scores = Program.ListFromFile("points.txt");
            scores.Sort();
            scores.Reverse();
        }

        public void SaveToFile()
        {
            string output = String.Join("\n", scores);

            System.IO.File.WriteAllText("points.txt", output);
        }

        public void PrintAll()
        {
            Console.WriteLine("--~~== HIGH SCORES ==~~--");

            /*for (int i=0; i<scores.Count; i++)
            {
                Console.WriteLine(scores[i]);
            }*/

            Console.WriteLine(String.Join("\n", scores));

        }

        public void AddScore(int pts, string name)
        {
            string newRow = pts.ToString("D5");

            scores.Add(newRow + " " + name);
            scores.Sort();
            scores.Reverse();
        }
    }
}
