using System;
namespace Day17
{
    abstract class Runners
    {
        public string firstName;
        public string lastName;
        public Runners()
        {
            firstName = "";
            lastName = "";
        }
        public Runners(string newFirstName, string newLastName)
        {
            firstName = newFirstName;
            lastName = newLastName;
        }
        public override string ToString()
        {
            return ("Runners Name: " + firstName + " " + lastName);
        }
    }
}