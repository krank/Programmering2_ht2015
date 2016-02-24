using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilhanteringFacitGrp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HighScoreManager hm = new HighScoreManager();
            hm.LoadFromFile();
            hm.AddScore(9001, "Micke");
            hm.PrintAll();

            hm.SaveToFile();

            Console.ReadLine();
        }

        public static List<String> ListFromFile(string fileName)
        {
            List<string> rowsClean = new List<string>();

            if (System.IO.File.Exists(fileName))
            {

                string content = System.IO.File.ReadAllText(fileName);

                string[] rows = content.Split('\n');

                for (int i = 0; i < rows.Length; i++)
                {
                    if (rows[i].Trim() != "")
                    {
                        rowsClean.Add(rows[i].Trim());
                    }
                }
            }
            else
            {
                rowsClean.Add("FILE NOT FOUND");
            }

            return rowsClean;

        }
    }
}
