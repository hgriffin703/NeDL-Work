using System;

namespace Competency //same namespace as Program
{
    class Salary: Employees //base class
    {
        private int annualSalary;
        public int AnnualSalary;//public salary
        private double salaryBonus;
        public double SalaryBonus; //public bonus
        public int GetSalary
        {
            get
            {
                return GetSalary;
            }
            set{
                GetSalary = AnnualSalary;
            }
        }

        public Salary() //call the object class again; constructor
        {
            annualSalary = 0; 
            salaryBonus = 0;
        }
    public Salary (string newFirstName, string newLastName, char newEType, int newAnnualSalary): base (newFirstName, newLastName, newEType) 
    {
        AnnualSalary = newAnnualSalary;
        salaryBonus = AnnualSalary*.1;

    }

    public override int GetSalary1()
    {
        return AnnualSalary;//sets the GetSalary from employees equal to the Annual Salary
    }
    public override string ToString() //overwrites the values to strings
    {
        return "The employees name is: " + firstName + " " + lastName + " and their salary is: " + AnnualSalary + " dollars and their bonus is: " + salaryBonus + " dollars.";
    }
  }
}