using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one student object

            Bike bike = new Bike();
            bike.Name = "jopo";
            bike.Model = " street";
            bike.Color = "kultainen";
            bike.Year = 2000;
            bike.Gear = false;

            Bike bike2 = new Bike();
            bike2.Name = "Tunturi";
            bike2.Model = " streetbomber";
            bike2.Color = "musta";
            bike2.Year = 1962;
            bike2.Gear = true;
            bike2.Gearmodel = "epic gear";

            Boat boat = new Boat();
            boat.Name = "Hilma";
            boat.Model = "S900";
            boat.Color = "valkoinen";
            boat.Year = 1950;
            boat.Boattype = "optimistijolla";
            boat.Seatnumber = 1;

            Boat boat2 = new Boat();
            boat2.Name = "Speedboat";
            boat2.Model = "Super2000";
            boat2.Color = "Liian nopea silmalle";
            boat2.Year = 2020;
            boat2.Boattype = "supervene";
            boat2.Seatnumber = 3;

            Console.WriteLine(bike.ToString());
            Console.WriteLine(bike2.ToString());
            Console.WriteLine(boat.ToString());
            Console.WriteLine(boat2.ToString());

            Boat boat3 = new Boat("nakkivene", "seikkailumalli", "hopeinen", 1900, "purtilo", 2);

            Console.WriteLine(boat3.ToString());

        }
    }
}
