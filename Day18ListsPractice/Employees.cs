using System;
namespace Day18
{
     class Employees
    {
        public string fName;
        public string lName;
        public char empType;
        public Employees()
        {
            fName = "";
            lName = "";
            empType = '\0';
        }
        public Employees(string newFName, string newLName, char newEmpType)
        {
            fName = newFName;
            lName = newLName;
            empType = newEmpType;
        }
        public override string ToString()
        {
            return ("The Employees Name: " + fName + " " + lName + " | Emp Type: " + empType);
        }
    }
}