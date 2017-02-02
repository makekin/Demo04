using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();
            hissi.Floornumber = 1;
            bool result;
            int floor;
            do
            {
                Console.WriteLine("The elevator is in " + hissi.Floornumber + " floor");
                Console.WriteLine("Please select a floor (1-5)");
                string line = Console.ReadLine();
                result = int.TryParse(line, out floor);
                if (result)
                {
                    hissi.Floornumber = floor;
                }

                else { Console.WriteLine("please select a number instead of alphabet "); }

                
            }
            while (floor != 0);
        }
    }
}
