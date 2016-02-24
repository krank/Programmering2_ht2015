using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilhanteringFacitGrp2
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
            string[] sc = scores.ToArray();

            string output = string.Join("\n", sc);

            System.IO.File.WriteAllText(@"points.txt", output);

        }

        public void PrintAll()
        {
            Console.WriteLine("--== HIGH SCORES ==--");

            for (int i = 0; i < scores.Count(); i++)
            {
                Console.WriteLine("#" + (i + 1) + ": " + scores[i]);
            }

        }

        public void AddScore(int pts, string name)
        {
            string pt = pts.ToString("0000");

            scores.Add(pt + " " + name);
            scores.Sort();
            scores.Reverse();
        }

    }
}
