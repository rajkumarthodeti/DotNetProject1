using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Project_1
{
    //Base class
    class Bofabank
    {
        public String Fname;
        public String Lname;
        public uint empid;
       // public float empSal;
        public string designation;

        public enum employeelevel
        {
            junioremp=3,
            senioremp,
            lead,
            manager,
          
        };


    }
}
