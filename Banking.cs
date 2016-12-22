using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dot_Net_Project_1
{
    class Banking
    {
        public static void Main(string[] args)

        {
            Empolyee b1 = new Empolyee();

           string gh = b1.Empolyeedetails();
            var x=gh=="junioremp" ?3:b1.designation == "senioremp"?4: b1.designation == "lead"?5:6;
            
            b1.salary(x);
            int i;
            for(i=0; i<x;i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

   
}
}
