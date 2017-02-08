using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Creature
    {
        public string Name { get; set; }
        public string Weapon { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }

        public Creature() { }

        public Creature(string name, string weapon, string type, int level)
        {
            Name = name;
            Weapon = weapon;
            Type = type;
            Level = level;
        }

        public void CreatureMethod()
        {
            Console.WriteLine("This method belongs to creatures!");
        }

        public override string ToString()
        {
            return Name + " " + Weapon + " " + Type + " " + Level;
        }

    }
}
