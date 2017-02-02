using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Phonenumber { get; set; }

        public Person() { }

        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public void PersonMethod()
        {
            Console.WriteLine("This method belongs to person!");
        }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + Age + " " + Phonenumber;
        }

    }
}
