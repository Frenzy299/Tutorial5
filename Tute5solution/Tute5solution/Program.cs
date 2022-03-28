using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tute5solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss bigMan = new Boss();
            bigMan.display();

            Console.WriteLine(" ");

            bigMan.Use(102);
            bigMan.Fire(101);

            Console.WriteLine(" ");

            bigMan.display();
        }

        static List<Employee> generateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee a = new Employee { name = "Alfred", id = 101, gender = "M" };
            Employee b = new Employee { name = "Bruce", id = 102, gender = "M" };
            Employee e = new Employee { name = "Shelley", id = 100, gender = "F" };

            employees.Add(a);
            employees.Add(b);
            employees.Add(e);

            return employees;
        }

        static void printList(List<Employee> list)
        {
            foreach (Employee e in list)
            {
                Console.WriteLine(e);
            }
        }

        static List<Employee> filterByGender(List<Employee> staff, string gender)
        {
            List<Employee> filteredList = new List<Employee>(); ;

            foreach (Employee e in staff)
            {
                if (e.gender == gender)
                {
                    filteredList.Add(e);
                }
            }

            return filteredList;
        }

        void oldMain()
        {
            string input = "";
            //printList(generateEmployees());
            while (input != "exit")
            {
                Console.WriteLine("Search for which gender? ");
                input = Console.ReadLine();
                printList(filterByGender(generateEmployees(), input));
            }
        }
    }
}
