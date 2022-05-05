using System;
namespace PetProject
{
    class Runners
    {
        public string firstName;
        public string lastName;
        public string raceName;
        public string distance;
        public Runners()
        {
            firstName = "";
            lastName = "";
            raceName = "";
            distance = "";
        }
        public Runners(string newFirstName, string newLastName, string newRaceName, string newDistance)
        {
            firstName = newFirstName;
            lastName = newLastName;
            raceName = newRaceName;
            distance = newDistance;
        }
        public override string ToString()
        {
            return ("Runners Name: " + firstName + " " + lastName + " | Race Name: " + raceName + " | Distance: " + distance);
        }
    }
}