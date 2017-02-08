using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {

            Creature creature = new Creature();
            creature.Name = "pikkunilkki";
            creature.Weapon = "mora";
            creature.Type = "paha";
            creature.Level = 3;

            Console.WriteLine(creature.ToString());

            God god = new God("Zeus", "Atrain", "paha", 50, "Salama", 25000);

            Console.WriteLine(god.ToString());

        }
    }
}
