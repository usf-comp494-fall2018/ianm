using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    
        public class Partimeemployee : Employee
        {
            //constructor 
            public Partimeemployee()
            {

            }
            //class
            public Partimeemployee(string fname, string lname, string CodeEmp, DateTime Currentime, int annualsal)
            {
                this.Fname = fname;
                this.Lname = lname;
                this.CodeEmployee = CodeEmp;
                this.Annualsal = annualsal;
                this.Dhired = Currentime;

            }

            //cout function 
            public new void WriteToConsole()
             { 
                 Console.WriteLine("Annual Salary: "+Annualsal);
            }



        }
    }


