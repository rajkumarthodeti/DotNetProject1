using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Project_1
{
    //Derived class
    class Empolyee:Bofabank
    {
        
        public string Empolyeedetails()
        {

            Empolyee e1 = new Empolyee();
            Console.WriteLine("Enter Empolyee First name:");
            e1.Fname = Console.ReadLine();

            Console.WriteLine("Enter Empolyee Last name:");
            e1.Lname = Console.ReadLine();

            Console.WriteLine("Enter Empolyee ID:");
            e1.empid = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Enter Empolyee Designation:");
            e1.designation = Console.ReadLine();

            return e1.designation;
            


        }


        public void salary(int empl)
        {


            switch (empl)
            {
                case (int)(employeelevel.junioremp):
                    Console.WriteLine("Salary of junioremp per anum is:65K");
                    break;
                case (int)employeelevel.senioremp:
                    Console.WriteLine("Salary of senioremp per anum is:85K");
                    break;
                case (int)employeelevel.lead:
                    Console.WriteLine("Salary of lead per anum is:95K");
                    break;
                case (int)employeelevel.manager:
                    Console.WriteLine("Salary of manager per anum is:125K");
                    break;
                   default:
                    Console.WriteLine("Other staff salary:25k");
                    break;
            }
        }


    }

}

