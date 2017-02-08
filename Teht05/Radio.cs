using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Radio
    {

        private readonly int maxvolume = 100;
        private readonly int minvolume = 1;
        private readonly double maxtaajuus = 26000;
        private readonly double mintaajuus = 2000;
        private double taajuus;
        private int volume;

        public int Volume
        {
            get
            { return volume; }
            set
            {

                if (value == volume) { Console.WriteLine("\nYour volume is already set on that!"); }

                else
                {
                    if (value >= minvolume && value <= maxvolume) volume = value;
                    else if (value <= minvolume)
                    {
                        Console.WriteLine("\nThat is too low volume! \n");
                        volume = minvolume;
                    }

                    else if (value >= maxvolume)
                    {
                        Console.WriteLine("\nThat is too high volume! \n");
                        volume = maxvolume;
                    }
                }
            }
        }

        public double Taajuus
        {
            get
            { return taajuus; }
            set
            {
                if (value == taajuus) { Console.WriteLine("Your frequency is already set on that!"); }

                else
                {
                    if (value >= mintaajuus && value <= maxtaajuus) taajuus = value;
                    else if (value <= mintaajuus)
                    {
                        Console.WriteLine("That is too low frequency! \n");
                        taajuus = mintaajuus;
                    }

                    else if (value >= maxtaajuus)
                    {
                        Console.WriteLine("That is too high frequency! \n");
                        taajuus = maxtaajuus;
                    }
                }
            }
        }
    }
}
