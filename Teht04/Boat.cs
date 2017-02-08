using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Boat : Kulkuneuvo
    {

        public string  Boattype { get; set; }
        public int Seatnumber { get; set; }
        public Boat()
        {

        }

        public Boat(string name, string model, string color, int year, string boattype, int seatnumber)
            :base(name, model, color, year)
        {
            Boattype = boattype;
            Seatnumber = seatnumber;
        }

        public void BoatMethod()
        {
            Console.WriteLine("This method belongs to Boat!");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Boattype + " " + Seatnumber;
        }


    }

}
