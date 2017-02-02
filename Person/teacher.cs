using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Teacher: Person
    {
        public string Room { get; set; }

        public Teacher()
        {

        }

        public Teacher(string firstname, string lastname, string room)
            : base(firstname, lastname)
        {
            Room = room;
        }

        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to Teacher!");
        }

        public override string ToString()
        {
            //Person-luokan to string + Room. Base to string tarkoittaa yliluokan to string methodia
            //Base viittaa yliluokkaan eli nyt person luokkaan. tulostaa firstname, lastname etc. 
            return base.ToString()+ " " + Room;
        }

    }
    
}
