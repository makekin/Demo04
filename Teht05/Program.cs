using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.Volume = 1;
            radio.Taajuus = 2000;
            bool result;
            bool power = true;
            while (power == true)
            {
                int choice;
                Console.WriteLine("welcome to radio software! Please select what you want to do: \n1) select frequency\n2) select volume \n3) close radio");
                Console.WriteLine("\nyour current setup is: \nFrequency: " + radio.Taajuus+ " \nvolume: "+ radio.Volume+ "\n");
                string line = Console.ReadLine();
                result = int.TryParse(line, out choice);
                if (result == true)
                {
                    switch (choice)
                    {
                        case 1:
                            int taajuus;
                            Console.WriteLine("\nVahvistimen taajuus on " + radio.Taajuus);
                            Console.WriteLine("Valitse taajuus: ");
                            string line2 = Console.ReadLine();
                            Console.WriteLine();
                            result = int.TryParse(line2, out taajuus);
                            if (result == true)
                            {
                                radio.Taajuus = taajuus;
                            }
                            break;

                        case 2:
                            int volume;
                            Console.WriteLine("Radion volyymi on " + radio.Volume);
                            Console.WriteLine("Please set the volume level: ");
                            string line3 = Console.ReadLine();
                            result = int.TryParse(line3, out volume);
                            if (result == true)
                            {
                                radio.Volume = volume;
                            }
                            break;
                        case 3:
                            Console.WriteLine("you shutdown the radio!");
                            power = false;
                            break;

                    }





                }

            }
        }

    }
}