using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tute5solution
{
    abstract class Agency
    {

        public static List<Employee> generate()
        {
            List<Employee> staff = new List<Employee>()
            {
                new Employee { name = "Alfred", id = 101, gender = "M" },
                new Employee { name = "Bruce", id = 102, gender = "M" },
                new Employee { name = "Janet", id = 100, gender = "F" },
                new Employee { name = "Sally", id = 103, gender = "F"}
            };

            return staff;
        }

    }
}
