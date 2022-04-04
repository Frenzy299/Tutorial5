using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tute5solution
{
    class Boss
    {
        public List<Employee> staff;

        public Boss ()
        {
            staff = Agency.generate();
        }

        public void display ()
        {
            foreach (Employee e in staff)
            {
                Console.WriteLine(e);
            }
        }

        public Employee Use(int id)
        {
            foreach (Employee e in staff)
            {
                if (e.id == id)
                {
                    Console.WriteLine(e.name + " is now in use.");
                    return e;
                }
            }

            Console.WriteLine("Nothing found.");
            return null;
        }

        public Employee Fire(int id)
        {
            foreach (Employee e in staff)
            {
                if (e.id == id)
                {
                    staff.Remove(e);
                    Console.WriteLine(e.name + " no longer works for this company.");
                    return e;
                }
            }

            Console.WriteLine("Nothing found.");
            return null;
        }
    }
}
