using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Vahvistin
    {
        
        private readonly int maxvolume = 100;
        private readonly int minvolume = 1;
        private int volume;

        public int Volume
        {
            get
            { return volume; }
            set
            {
                if (value == volume) { Console.WriteLine("Your volume is already set on that!"); }

                else
                {
                    if (value >= minvolume && value <= maxvolume) volume = value;
                    else if (value <= minvolume)
                    {
                        Console.WriteLine("That is too low volume ");
                        volume = minvolume;
                    }

                    else if (value >= maxvolume)
                    {
                        Console.WriteLine("That is too high volume ");
                        volume = maxvolume;
                    }
                }
            }
        }
    }
}
