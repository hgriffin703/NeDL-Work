using System;
namespace Day15Lists
{
    class Hourly: Employees
    {
        public double hourlyRate;
        public Hourly()
        {
            hourlyRate = 0.0;
        }
        public Hourly (string newFirstName, string newLastName, char newEmpType, double newHourlyRate): base(newFirstName, newLastName, newEmpType)
        {
            hourlyRate = newHourlyRate;
        }
        public override double GetBonus()
        {
            return hourlyRate * 80;
        }
        public override string ToString()
        {
            return base.ToString() + " | Hourly rate:" + hourlyRate + " | Bonus: " + GetBonus();
        }
    }
}