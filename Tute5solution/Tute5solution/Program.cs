using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tute5solution
{
    public delegate Employee ManageWorker(int id);

    class Program
    {
        static void Main(string[] args)
        {
            Action doSomething;
            ManageWorker manage;

            Boss bigMan = new Boss();

            doSomething = bigMan.display;
            manage = bigMan.Use;

            doSomething(); //print list
    
            manage(101);

            doSomething() ; //print list

            // change the manage function during code execution
            manage = bigMan.Fire;

            manage(103);
            doSomething();
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
