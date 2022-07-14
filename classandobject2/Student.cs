using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classandobject2
{
    internal class Student
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Marks { get; set; }


        //default constructor
        public Student()
        {
            Id = 1;
            Firstname = "Bunny";
            Lastname = "Butcher";
            Marks = 90;
        }

        public Student(int id, string firstname, string lastname, int marks)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Marks = marks;
        }

        //standard class object
        public override string ToString()
        {
            return Id + " " + Firstname + " " + Lastname + Marks;
        }
    }
}
