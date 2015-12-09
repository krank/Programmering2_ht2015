using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grp2Static
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Enemy e1 = new Enemy();
            Enemy e2 = new Enemy();

            Enemy.count = 3;

            e1.addToCount();

            e2.printCount();


            Console.ReadLine();
        }

        class Enemy
        {
            public static int count = 0;

            public void addToCount()
            {
                count += 1;
            }

            public void printCount()
            {
                Console.WriteLine(count);
            }
        }



    }
}
