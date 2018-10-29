using Homework4;
using System;

namespace Homework4
{
    class EmployeeApp
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee
            {
                Fname = "Ian",
                Lname = "Millan",
                Dhired = new DateTime(1996, 09, 30),
                CodeEmployee = "9999"
            };
            PermanentEmployee emp2 = new PermanentEmployee
            {
                Fname = "Paco",
                Lname = "Martinez",
                Dhired = new DateTime(2000, 01, 09),
                CodeEmployee = "88888"
            };
            emp2.Annualsal = 200600;
           Partimeemployee emp3 = new Partimeemployee
            {
               Fname = "Lucas",
               Lname = "Navarro",
               Dhired = new DateTime(1996, 09, 24),
               CodeEmployee = "00001"
           };
            emp3.HourRate = 18;

            Console.WriteLine("Displaying emp1 " + emp1);


            Console.WriteLine("\nDisplying emp2 " + emp2);
           

            Console.WriteLine("\nDisplaying emp3 " + emp3);
        }
    }
}