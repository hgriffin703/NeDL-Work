using System;
namespace Day18
{
     class Hourly: Employees
    {
        public double hourlyRate;
        public Hourly()
        {
            hourlyRate = 0.0;
        }
        public Hourly(string newFName, string newLName, char newEmpType, double newHourlyRate): base (newFName, newLName, newEmpType)
        {
            hourlyRate = newHourlyRate;
        }
           public double GetBonus() // interface method
        {
            return hourlyRate * 80;
        }
        public override string ToString()
        {
            return base.ToString() + " | Hourly rate:" + hourlyRate + " | Bonus: " + GetBonus();
        }     
        
    }
}