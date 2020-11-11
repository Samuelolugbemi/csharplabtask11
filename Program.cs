using System;
using System.Collections.Generic;
using System.Collections;
namespace LabTask11
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> employeesList = new Dictionary<string, string>();
                employeesList.Add("Tom Lee","Training");
                employeesList.Add("James Anderson","HR");
                employeesList.Add("Michael Chan","Content Development");
                employeesList.Add("Jackie Jackson","Training");
                employeesList.Add("Bruce Douglas","Graphics");
                employeesList.Add("Kim Date","HR");
                employeesList.Add("Joseph Matthews","Content Development");
                employeesList.Add("Rose Dorson","Marketing");
                employeesList.Add("Andrews Stephan","Graphics");
            SortedList<string,string> employees = new SortedList<string,string>();
                employees.Add("Tom Lee","Training");
                employees.Add("James Anderson","HR");
                employees.Add("Michael Chan","Content Development");
                employees.Add("Jackie Jackson","Training");
                employees.Add("Bruce Douglas","Graphics");
                employees.Add("Kim Date","HR");
                employees.Add("Joseph Matthews","Content Development");
                employees.Add("Rose Dorson","Marketing");
                employees.Add("Andrews Stephan","Graphics");
            Console.WriteLine("Displaying items in the Dictionary collection\n");
            Console.WriteLine("Name\t\tDepartment");
            foreach (var item in employeesList)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine("\nDisplaying items in the Sorted List collection\n");
            Console.WriteLine("Name\t\tDepartment");
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine("\nDisplaying items in the Dictionary collection after removing Andrews Stephan\n");
            if (employeesList.ContainsKey("Andrews StephAn"))
            {
                employeesList.Remove("Andrews Stephan");
            }
            Console.WriteLine("Name\t\tDepartment");
            foreach (var item in employeesList)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine("\nDisplaying items in the Sorted List collection after removing Andrews Stephan\n");
            if (employees.ContainsKey("Andrews StephAn"))
            {
                employees.Remove("Andrews Stephan");
            }
            Console.WriteLine("Name\t\tDepartment");
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
