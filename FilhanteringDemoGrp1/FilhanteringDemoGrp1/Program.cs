using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilhanteringDemoGrp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = "Håkan,Herbert,Walle,Valfrid,Eva-Lena";

            string[] ts = t.Split('\n');

            Console.WriteLine(ts[1]);

            List<string> ts2 = new List<string>(ts);




            if (System.IO.File.Exists(@"mytext.txt"))
            {
                string text = System.IO.File.ReadAllText(@"mytext.txt");

                Console.WriteLine(text);
            } else
            {
                Console.WriteLine("NOOOOoooo!");

            }

            string newText = Console.ReadLine();

            System.IO.File.WriteAllText(@"mytext.txt", newText);


            Console.ReadLine();
        }
    }
}
