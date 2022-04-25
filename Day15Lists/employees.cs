using System;

namespace Day15Lists //same namespace as Program
{
    abstract class Employees //base class; that is an abstract class
    {
        public string firstName;
        public string lastName;
        public char empType;

        public Employees()
        {
            firstName = "";
            lastName = "";
            empType = '\0';            
        }
        public Employees(string newFirstName, string newLastName, char newEmpType)
        {
            firstName = newFirstName;
            lastName = newLastName;
            empType = newEmpType;
        }

        public abstract double GetBonus();

        public override string ToString()
        {
            return ("The employee is: " + firstName + " " + lastName + " and they are a: " + empType);
        }
    }
}
