using System;
namespace PetProject
{
    class Runners
    {
        public string firstName;
        public string lastName;
        public string raceName;
        public string distance;
        public int weeklyMiles;
        public Runners()
        {
            firstName = "";
            lastName = "";
            raceName = "";
            distance = "";
            weeklyMiles = 0;
        }
        public Runners(string newFirstName, string newLastName, string newRaceName, string newDistance, int newWeeklyMiles)
        {
            firstName = newFirstName;
            lastName = newLastName;
            raceName = newRaceName;
            distance = newDistance;
            weeklyMiles = newWeeklyMiles;
        }
        public virtual void SetWeeklyMileage(int DailyMiles)
        {
            weeklyMiles = weeklyMiles + DailyMiles;
        }
        public override string ToString()
        {
            return ("Runners Name: " + firstName + " " + lastName + " | Race Name: " + raceName + " | Distance: " + distance + "Weekly Miles: " + weeklyMiles);
        }
    }
}