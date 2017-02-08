using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class God:Creature
    {

        public string Godtype { get; set; }
        public int Hp { get; set; }
        public God()
        {

        }

        public God(string name, string weapon, string type, int level, string godtype, int hp)
            :base(name, weapon, type, level)
        {
            Godtype = godtype;
            Hp = hp;
        }

        public void GodMethod()
        {
            Console.WriteLine("This method belongs to God!");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Godtype + " " + Hp;
        }


    }

}