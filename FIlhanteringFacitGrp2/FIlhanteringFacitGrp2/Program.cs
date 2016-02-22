using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilhanteringFacitGrp2
{
    class Program
    {
        static void Main(string[] args)
        {
            HighScoreManager hm = new HighScoreManager();

            hm.LoadFromFile();

            hm.AddScore(66, "Rundlöf");

            hm.PrintAll();

            hm.SaveToFile();


            /*Enemy e1 = new Enemy();
            Enemy e2 = new Enemy();

            Console.WriteLine(e1.name);
            Console.WriteLine(e2.name);*/


            Console.ReadLine();
        }

        public static List<string> ListFromFile(string fileName)
        {
            List<string> rowList = new List<string>();

            if (!System.IO.File.Exists(fileName))
            {
                rowList.Add("FILE NOT FOUND");
                return rowList;
            }

            String content = System.IO.File.ReadAllText(@fileName);

            string[] rows = content.Split('\n');

            for (var i = 0; i < rows.Length; i++)
            {
                if (rows[i].Length > 1)
                {
                    rowList.Add(rows[i]);
                }
            }

            return rowList;
        }
    }
}
