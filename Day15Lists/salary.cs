using System;

namespace Day15Lists
{
    class Salary: Employees
    {
        public int annualSalary;
        public Salary()
        {
            annualSalary = 0;
        }
        public Salary (string newFirstName, string newLastName, char newEmpType,int newAnnualSalary): base (newFirstName, newLastName, newEmpType)
        {
            annualSalary = newAnnualSalary;
        }
        public override string ToString()
        {
            return base.ToString() + " their annual salary is: " + annualSalary;
        }
    }
}