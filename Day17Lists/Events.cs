using System;
namespace Day17
{
    class Events: Runners
    {
        public string raceDistance;
        public string raceName;
        public string raceResult;
        public Events()
        {
            raceDistance = "";
            raceName = "";
            raceResult = "";
        }
        public Events(string newFirstName, string newLastName, string newRaceDistance, string newRaceName, string newRaceResult): base (newFirstName, newLastName)
        {
            raceDistance = newRaceDistance;
            raceName = newRaceName;
            raceResult = newRaceResult;
        }
        public override string ToString()
        {
            return base.ToString() + " | the Race: " + raceName + " | the Distance: " + raceDistance + " | the Result: " + raceResult; 
        }
    }
}