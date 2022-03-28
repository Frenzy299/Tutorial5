using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tute5solution
{
    public class Employee
    {
        public string name { get; set; }
        public int id {get; set;}
        public string gender { get; set; }

        public override string ToString()
        {
            return name + " " + id + " " + gender;
        }
    }
}
