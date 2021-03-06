using System;
using System.Collections.Generic;

namespace Day17
{
    class Program
    {
        static void Main(string[] args)
        {
                        bool validUserChoice = false;
            string userChoice;
            string fileName = @"Racers.txt";

            List<Events> RacersList = new List<Events>();
            do 
            {
            do
            {
        //initialize variables
            validUserChoice = false;
        //provide the user a menu of options
            Console.WriteLine("What would you like to do to the list today?");
            Console.WriteLine("L: Load the file into a list.");
            Console.WriteLine("S: Store the array in a file");
            Console.WriteLine("C: Add a name to the list.");
            Console.WriteLine("R: Read a name from the list.");
            Console.WriteLine("Q: Quit the program.");
        
            //get a valid user option (valid means it is on menu
            userChoice = Console.ReadLine();

            validUserChoice = (userChoice == "L" || userChoice == "l" 
                          ||userChoice == "S" || userChoice == "s" 
                          || userChoice == "C" || userChoice == "c" 
                          || userChoice == "R" || userChoice == "r"
                          || userChoice == "Q" || userChoice == "q");

            if(!validUserChoice)
            {
               Console.WriteLine("Please enter a valid option");
            }

            } while (!validUserChoice);


/*             RacersList.Add(new Events("Hayley", "Griffin", "Good Life Halfsy", "Half Marathon", "100th place"));
            RacersList.Add(new Events("Derek", "Loseke", "Boston Marathon", "marathon", "1st place"));
            RacersList.Add(new Events("Molly", "Seidel", "Tokyo Olympics", "Marthon", "Eigth Place")); */


            //in the L section
        if(userChoice == "L" || userChoice == "l")
        {
         List<string> list = new List<string>();
         using (StreamReader sr = File.OpenText("Racers.txt"))
         {
            int index = 0;
            string firstName;
            string lastName;
            string raceName;
            string raceDistance;
            string raceResult;

           while ((firstName = sr.ReadLine()) != null) //sets first line equal to first name
            {
                //firstName = sr.ReadLine();
                Console.WriteLine(firstName);

                lastName = sr.ReadLine(); //sets the second line of the file to lastName
                Console.WriteLine(lastName);

                raceName = sr.ReadLine(); //sets the third line of the file to eType
                Console.WriteLine(raceName);

                raceDistance = sr.ReadLine();
                Console.WriteLine(raceDistance);

                raceResult = sr.ReadLine();
                Console.WriteLine(raceResult);
        
              RacersList.Add(new Events(firstName, lastName, raceName, raceDistance, raceResult));
                
              foreach (Events Racers in RacersList)
              {
                Console.WriteLine(Racers);
              }  // end foreach  
            Console.WriteLine("");
            }
         }
        }
          else if (userChoice == "S" || userChoice == "s")
          {
            using(TextWriter tw = new StreamWriter("Racers.txt"))
            foreach (object Events in RacersList)
                tw.WriteLine(Events);
          }

 //close if statement
            //IN THE C SECTION
         if(userChoice == "C" || userChoice == "c")
        { 
           int index = 0;
          Console.WriteLine("What's the racers first name?");
            string newRacer = Console.ReadLine();
          Console.WriteLine("What is the racers last name?");
            string newRacerL = Console.ReadLine();
          Console.WriteLine("What's the race name?");
            string newRaceName = Console.ReadLine();
          Console.WriteLine("What is the race distance?");
            string newRaceDistance = Console.ReadLine();
          Console.WriteLine("What was the result of the race?");
            string newRaceResult = Console.ReadLine();

          bool found = false; //found for rest.
          Console.WriteLine(""); //entering a blank line to give some space
          
          //index to add it new rest to the array
          for (index = 0; index < RacersList.Count; index++)
          {
            if(found == false)
            {
              RacersList[index] = new Events(newRacer, newRacerL, newRaceName, newRaceDistance, newRaceResult);
              found = true;
                          
              Console.WriteLine(RacersList[index]); 
            } 
          } //end the for name loop
          
            if (found == false) 
          {
            Console.WriteLine("There is no space to add a new racer!");
            Console.WriteLine("");

          } 
        }

        //R SECTION
        else if(userChoice == "R" || userChoice == "r")
        {
        Console.Write("Please enter a Racer's last name to find: ");
        string findName = Console.ReadLine();
        bool found = false;
        foreach (Events racer in RacersList)
        {
            if (racer.lastName == findName)
            {
                Console.WriteLine(racer);
                found = true;
            }
        }  // end foreach  
        if (!(found))
            Console.WriteLine("Name was not found.");
          /* Console.WriteLine("in the R/r area");

         for (int index = 0; index < RacersList.Count; index++)
          {
            Console.WriteLine(RacersList[index]);
          } 
            Console.WriteLine(""); */
        }//close else if 

        //Q SECTION
        } while (!(userChoice == "Q" || userChoice == "q"));
      }
    }
}