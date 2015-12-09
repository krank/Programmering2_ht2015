using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionKlasser
{
    class Program
    {
        static void Main(string[] args)
        {

            Enemy firstEnemy = new Enemy();
            Enemy secondEnemy = new Enemy("Ross");

            List<Enemy> nmies = new List<Enemy>();

            nmies.Add(new Enemy("Hwite"));

            firstEnemy.hurt(2);

            Console.WriteLine(firstEnemy.hp);

            Console.WriteLine(firstEnemy.name);

            Console.ReadLine();

        }


        class Enemy
        {
            public int hp = 10;
            public string name;

            public Enemy(string inName)
            {
                Console.WriteLine("RAAAWR! " + inName + " LIVES AGAIN!");

                name = inName;
            }

            public Enemy()
            {
                name = "NONAME";
            }

            public void hurt(int amount)
            {
                hp -= amount;
            }


        }

    }
}
