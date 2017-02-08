using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Kulkuneuvo
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        
        public Kulkuneuvo() { }

        public Kulkuneuvo(string name, string model, string color, int year)
        {
            Name = name;
            Model = model;
            Color = color;
            Year = year;
        }

        public void KulkuneuvoMethod()
        {
            Console.WriteLine("This method belongs to kulkuneuvot!");
        }

        public override string ToString()
        {
            return Name + " " + Model + " " + Color + " " + Year;
        }

    }
}
