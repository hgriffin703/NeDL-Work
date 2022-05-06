using System;

namespace Competency //same namespace as Program
{
    class Employees //base class
    {
        public string firstName;
        public string lastName;
        public char eType;
       
        public Employees() //call the object class again; constructor
        {
            firstName = null; 
            lastName = null;
            eType = '\0';

        }
    public Employees (string newFirstName, string newLastName, char newEType)
    {
        firstName = newFirstName;
        lastName = newLastName;
        eType = newEType;

    }

    public virtual int GetSalary1()
//creates a dummy option here to call on the Hourly page for getting the array to be able to read the salary 

    {
        return -1;
    }
    public virtual double GetHourly() 
//creates a dummy option here to call on the Hourly page for getting the array to be able to read the hourly rate 
    {
        return -1.00;
    }

    public override string ToString() //overwrites the values to strings
    {
        return "The employees name is: " + firstName + " " + lastName + " and there employee type is: " + eType;
    }
  }
}