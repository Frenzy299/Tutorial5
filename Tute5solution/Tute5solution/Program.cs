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

            doSomething(); //print list

            // change the manage function during code execution
            manage = bigMan.Fire;

            manage(103);
            doSomething();

            Console.WriteLine("");
            printList(filterByGender(bigMan.staff, "F"));

            Console.WriteLine("");
            printList(filterByGender(bigMan.staff, "M"));

            Console.WriteLine(" \n--------\nTUTORIAL 6\n");

            // Full list of training sessions
            List<TrainingSession> sessions = new List<TrainingSession>() {
                new TrainingSession { Title = "HOW TO DO THING", Year = 2021, Certified = new DateTime(2021, 9, 16), Mode = Mode.Conference },
                new TrainingSession { Title = "WHEN TO DO THING", Year = 2015, Certified = new DateTime(2015, 7, 15), Mode = Mode.Journal },
                new TrainingSession { Title = "WHY TO DO THING", Year = 2016, Certified = new DateTime(2016, 7, 29), Mode = Mode.Other }
            };

            //Freshness <= 200 days
            var freshFilter = from tr in sessions
                              where tr.Freshness <= 200
                              select tr;
            
            //Occurred between 2014 and 2019
            var dateFilter = from tr in sessions
                             where tr.Year >= 2014 && tr.Year <= 2019
                             select tr;

            //Display a list with one of the filters
            foreach (TrainingSession tr in dateFilter)
            {
                Console.WriteLine(tr);
            }
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
            /*List<Employee> filteredList = new List<Employee>(); ;

            foreach (Employee e in staff)
            {
                if (e.gender == gender)
                {
                    filteredList.Add(e);
                }
            }*/

            var filtered = from p in staff
                           where p.gender == gender
                           select p;

            return new List<Employee>(filtered);
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
