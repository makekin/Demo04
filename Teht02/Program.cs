using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            Vahvistin vahvistin = new Vahvistin();
            vahvistin.Volume = 1;
            bool result;

            do
            {
                int volume;
                Console.WriteLine("Vahvistimen volyymi on " + vahvistin.Volume);
                Console.WriteLine("Please set the volume level: ");
                string line = Console.ReadLine();
                result = int.TryParse(line, out volume);
                if (result == true)
                {
                    vahvistin.Volume = volume;
                }

                else { Console.WriteLine("please select a number instead of alphabet next time"); }


            }
            while (result == true);
        }
    }
}

