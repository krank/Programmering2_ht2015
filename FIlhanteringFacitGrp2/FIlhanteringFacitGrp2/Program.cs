using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIlhanteringFacitGrp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ListFromFile("test.txt");
            Console.ReadLine();
        }

        public static List<string> ListFromFile(string fileName)
        {
            String content = System.IO.File.ReadAllText(@fileName);

            string[] rows = content.Split('\n');

            List<string> rowList = new List<string>();

            for (var i=0; i<rows.Length; i++)
            {

                if (rows[i].Length > 1)
                {
                    rowList.Add(rows[i]);
                }
            }

            Console.WriteLine(rowList.Count);

            return rowList;
        }
    }
}
