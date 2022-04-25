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
        }
    }
}
