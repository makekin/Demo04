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

            Student student = new Student();
            student.Firstname = "matti";
            student.Lastname = "meikalainen";
            student.Address = "esimkatu 5";
            student.Age = 24;
            student.Phonenumber = "12412124";
            student.StudentID = "Q1234";

            Console.WriteLine(student.ToString());

            Teacher teacher = new Teacher("Kirsi", "Kernel", "D566");
            teacher.Age = 35;
            teacher.Address = "koulukuja 5";
            teacher.Phonenumber = "+35812412";
            Console.WriteLine(teacher.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();
            student.PersonMethod();
        }
    }
}
