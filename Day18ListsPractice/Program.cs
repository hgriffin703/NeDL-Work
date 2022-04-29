using System;
using System.Collections.Generic;

namespace Day18
{
    class Program
    {
        static void Main(string[] args)
        {
         // Add a couple of hourly employees to the list to test
        List<Employees> EmployeeList = new List<Employees>();

        // Add a couple of employees to the list to test
            EmployeeList.Add(new Salary("Hayley", "Griffin", 'S', 100000)); //test for salary
            EmployeeList.Add(new Hourly("Derek", "Loseke", 'H', 25.60)); //test for hourly
            EmployeeList.Add(new Salary("Conor", "Hovey", 'S', 45000)); //test for salary
            EmployeeList.Add(new Hourly("Moose", "Loseke", 'H', 31.45)); //test for hourly

         // Print the list
        foreach (Employees theEmployee in EmployeeList)
        {
            Console.WriteLine(theEmployee);
        }  // end foreach 
        }
    }
}

