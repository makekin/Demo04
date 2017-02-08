using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }


        public Employee() { }

        public Employee(string name, string profession, int salary)
        {
            Name = name;
            Profession = profession;
            Salary = salary;
        }

        public void EmployeeMethod()
        {
            Console.WriteLine("This method belongs to employee!");
        }

        public override string ToString()
        {
            return Name + " " + Profession + " " + Salary;
        }

    }
}
