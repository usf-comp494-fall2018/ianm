using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    
        public class PermanentEmployee : Employee
        {
            //constructor 
            public PermanentEmployee()
            {

            }
            //class
            public PermanentEmployee(string fname, string lname, string CodeEmp, int Ratehours, DateTime Currentime)
            {
                this.Fname = fname;
                this.Lname = lname;
                this.CodeEmployee = CodeEmp;
                this.Dhired = Currentime;
                this.HourRate = Ratehours;
            }

            //cout function 
            public new void WriteToConsole()
            {
                Console.WriteLine("Rate for the hour: " + HourRate);
            }


           
        }
    
}

