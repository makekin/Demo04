using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one student object

            Employee employee = new Employee();
            employee.Name = "matti meikalainen";
            employee.Profession = "toimisto-orja";
            employee.Salary = 2000;

          

            Console.WriteLine(employee.ToString());

            Boss boss = new Boss("Kirsi Kernel", "uberboss", 3000, "mersu", 5000);
            Console.WriteLine(boss.ToString());
            boss.Car = "audi";
            boss.Bonus = 10000;
            boss.Salary = 3500;
            Console.WriteLine(boss.ToString());

            employee.Salary = 1000;
            Console.WriteLine(employee.ToString());
           // boss.BossMethod();
           // employee.EmployeeMethod();
            
        }
    }
}
