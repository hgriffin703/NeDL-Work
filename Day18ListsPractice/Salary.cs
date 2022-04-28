using System;
namespace Day18
{
     class Salary: Employees
    {
        public double annualSalary;
        public Salary()
        {
            annualSalary = 0.0;
        }
        public Salary(string newFName, string newLName, char newEmpType, double newAnnualSalary): base (newFName, newLName, newEmpType)
        {
            annualSalary = newAnnualSalary;
        }
           public double GetBonus() // interface method
        {
            return annualSalary * .1;
        }
        public override string ToString()
        {
            return base.ToString() + " | Annual Salary:" + annualSalary + " | Bonus: " + GetBonus();
        }     
        
    }
}