using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Hissi
    {
        private readonly int maxfloor = 5;
        private readonly int minfloor = 1;
        private int floornumber;

        public int Floornumber {
            get
            { return floornumber; }
            set
            {
                if (value == floornumber) { Console.WriteLine("you're already in that floor! pick another!"); }

                else
                {
                    if (value >= minfloor && value <= maxfloor) floornumber = value;
                    else { Console.WriteLine("That floor doesn't exist. Pick another"); }
                }
            }
        }
    }
}
