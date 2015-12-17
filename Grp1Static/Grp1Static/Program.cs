using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grp1Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy e1 = new Enemy();
            Enemy e2 = new Enemy();


            Enemy.count = 5;

            e1.AddToCount();

            e2.PrintCount();


            Console.ReadLine();
        }

        class Enemy
        {
            public int hp;
            public static int count;

            public void AddToCount()
            {
                count++;
            }

            public void PrintCount()
            {
                Console.WriteLine(count);
            }
        }


    }
}
