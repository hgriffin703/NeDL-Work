using System;
namespace PetProject
{
    class Runners
    {
        public string firstName;
        public string lastName;
        public string distance;
        public Runners()
        {
            firstName = "";
            lastName = "";
            distance = "";
        }
        public Runners(string newFirstName, string newLastName, string newDistance)
        {
            firstName = newFirstName;
            lastName = newLastName;
            distance = newDistance;
        }
        public override string ToString()
        {
            return ("Runners Name: " + firstName + " " + lastName + " | Distance: " + distance);
        }
    }
}