using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunnerRoster
{
    internal class Runners
    {
        string fname;
        string lname;
        string distance;
        string raceName;

        public Runners()
            {
            fname = "";
            lname = "";
            distance = "";
            raceName = "";
            }
        public Runners(string newFName, string newLName, string newDistance, string newRaceName)
        {
            fname = newFName;
            lname = newLName;  
            distance = newDistance;
            raceName = newRaceName;
        }
       public override string ToString()
        {
            return "Runners Name: " + fname + " " + lname + " | Race and Distance: " + raceName + " | " + distance;
        }
    }
}
