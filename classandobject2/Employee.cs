using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classandobject2
{
    public enum department { IT,HR,Data_analytics}
    internal class Employee
    {
        public int id { get; set; }
        public static int count;
        public string fName { get; set; }
        public string lName { get; set; }
        public int salary { get; set; }

        public Date dateofjoining;
        public decimal gross_sal { get; set; }
        public department dept;

        static Employee()
        {
            count = 0;
            Console.WriteLine("This is it");
        }

        public Employee()
        {
            this.id = id;
            this.fName = fName;
            this.lName = lName;
            this.salary = salary;
            dateofjoining = doj;
            count++;
        }
        public Employee(int id, string fName, string lName, int salary, Date doj)
        {
            this.id = id;
            this.fName = fName;
            this.lName = lName;
            this.salary = salary;
            dateofjoining = doj;
            count++;
        }
        public static int showEmployeeCount()
        {
            return count;
        }
        //public Employee() { }
        public override string ToString()
        {
            return "ID: " + this.id + "\nName is : " + this.fName + " " + this.lName + "\nSalary is :" + this.salary + "\nCount :" + count+ "\nDate of Joining :" +dateofjoining;
        }
    }
}


