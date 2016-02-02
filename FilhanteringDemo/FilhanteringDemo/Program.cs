using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilhanteringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = System.IO.File.ReadAllText(@"TextFile1.txt");

            string[] rows = s.Split('\n');

            List<string> wordsList = new List<string>(rows);


            Console.WriteLine(wordsList[0]);

            wordsList.Add("Micke");

            string outLines = String.Join("\n", wordsList.ToArray());

            Console.WriteLine(outLines);

            System.IO.File.WriteAllText(@"TextFile1.txt", outLines);

            Console.ReadLine();
        }
    }
}
