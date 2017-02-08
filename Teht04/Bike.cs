using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Bike : Kulkuneuvo
    {
     
        public bool Gear { get; set; }
        public string Gearmodel { get; set; }
        public Bike()
        {

        }

        public Bike(string name, string model, string color, int year, bool gear, string gearmodel)
            :base(name, model, color, year)
        {
            Gear = gear;
            Gearmodel = gearmodel;
        }

        public void BikeMethod()
        {
            Console.WriteLine("This method belongs to Bike!");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Gear + " " + Gearmodel;
        }


    }

}
