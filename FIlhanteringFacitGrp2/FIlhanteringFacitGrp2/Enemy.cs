using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilhanteringFacitGrp2
{
    class Enemy
    {
        public string name;

        private static Random generator = new Random();

        public Enemy()
        {
            List<string> names = Program.ListFromFile("names.txt");

            //Random generator = new Random();

            int nameIndex = generator.Next(names.Count);

            name = names[nameIndex];

        }

    }
}
