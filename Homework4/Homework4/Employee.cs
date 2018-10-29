using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    public class Employee
    {
        public Employee()
        {
            Fname = "First name";
            Lname = "Last name";
            Dhired = new DateTime();
            CodeEmployee = "Code for ";
           
        }
      //class constructor 
        public Employee(string fname, string lname, string CodeEmp, DateTime Currentime)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.CodeEmployee = CodeEmp;
            this.Dhired = Currentime;
        }

        //cout console to write(function)
        public void WriteToConsole()
        {
            Console.WriteLine("Employee name: " + Fname + " " + Lname);
            Console.WriteLine("Employee ID is: " + CodeEmployee);
            Console.WriteLine("Hired date is: " + Dhired);
        }

       //declarations 
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string CodeEmployee { get; set; }
        public DateTime Dhired { get; set; }
        public int HourRate { get; set; }
        public int Annualsal { get; set; }

    }

}

