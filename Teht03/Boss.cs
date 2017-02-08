using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        public Boss()
        {

        }

        public Boss(string name, string profession, int salary, string car, int bonus)
            : base(name, profession, salary)
        {
            Car = car;
            Bonus = bonus;
        }

        public void BossMethod()
        {
            Console.WriteLine("This method belongs to Boss!");
        }

        public override string ToString()
        {
            //Person-luokan to string + Room. Base to string tarkoittaa yliluokan to string methodia
            //Base viittaa yliluokkaan eli nyt person luokkaan. tulostaa firstname, lastname etc. 
            return base.ToString() + " " + Car + " " + Bonus;
        }

    }

}
