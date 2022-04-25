/* 
// C# program to create a List<T>
using System;
using System.Collections.Generic;
  
class Geeks {
  
    // Main Method
    public static void Main(String[] args)
    {
  
        // Creating a List of integers
        List<string> firstlist = new List<string>();
  
        firstlist.Add("Jenny"); //this is item 0 just like in Arrays
        firstlist.Add("Erica");
        firstlist.Add("Hayley");

        // displaying the first
        // of elements of List<T>
        Console.WriteLine(firstlist[1]);//calls item in the 1 place of the list
    }
} */

using System;
using System.Collections.Generic;

namespace Day15Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employees newEmployee = new Employees ("Hayley", "Griffin", 'S');
            //Console.WriteLine(newEmployee);
            Salary newSalary = new Salary("Hayley", "Griffin", 'S', 100000);
            Console.WriteLine(newSalary);
            Hourly newHourly = new Hourly("Derek", "Loseke", 'H', 25.60);
            Console.WriteLine(newHourly);

            List<Salary> salaryemployeeList = new List<Salary>();
            salaryemployeeList.Add(new Salary("Hayley", "Griffin", 'S', 99000));
            salaryemployeeList.Add(new Salary("Derek", "Loseke", 'S', 85000));
            salaryemployeeList.Add(new Salary("Kristen", "Bell", 'S', 250000));

            Console.WriteLine(salaryemployeeList[2]);
        }
    }
}
