using System;

namespace PetProject //must be the same namespace througout
{
  class Program
  {
      static void Main(string[] args)
      {
          bool validUserChoice = false;
          string userChoice;
          string fileName = @"runners.txt";

      //Employees[] EmployeeArray = new Employees[25]; //Employee array create

          do 
      {
          do
      {
      //initialize variables
      validUserChoice = false;
      //provide the user a menu of options
      Console.WriteLine("What would you like to do to the array today?");
      Console.WriteLine("L: Load the file into an array.");
      Console.WriteLine("S: Store the array in a file");
      Console.WriteLine("C: Add a runner to the file");
      Console.WriteLine("R: Get info about a runner");
      Console.WriteLine("T: Track your miles");
      Console.WriteLine("TL: How much time is left until my race?");
      Console.WriteLine("Q: Quit the program");
      
      //get a valid user option (valid means it is on menu
      userChoice = Console.ReadLine();

      validUserChoice = (userChoice == "L" || userChoice == "l" 
                        ||userChoice == "S" || userChoice == "s" 
                        || userChoice == "C" || userChoice == "c" 
                        || userChoice == "R" || userChoice == "r"
                        || userChoice == "T" || userChoice == "t"
                        || userChoice == "TL" || userChoice == "tl"
                        || userChoice == "Q" || userChoice == "q");

      if(!validUserChoice)
      {
        Console.WriteLine("Please enter a valid option");
      }

        } while (!validUserChoice);

          List<Runners> RunnersList = new List<Runners>();

/*           RunnersList.Add(new Runners("Hayley", "Griffin", "Half Marathon")); //test for salary
          RunnersList.Add(new Runners("Derek", "Loseke", "Marathon"));
          RunnersList.Add(new Runners("Jon", "Foss", "Half Marathon"));
          RunnersList.Add(new Runners("Seth", "Marek", "Marathon"));
          RunnersList.Add(new Runners("Seth", "Prauner", "Marathon")); */
 

          //in the L section
      if(userChoice == "L" || userChoice == "l")
      {
        using (StreamReader sr = File.OpenText("runners.txt"))
        {
          string firstName;
          string lastName;
          string distance;

          while ((firstName = sr.ReadLine()) != null) //sets first line of the file to lastName
          {
              //firstName = sr.ReadLine();
              Console.WriteLine(firstName);

              lastName = sr.ReadLine(); //sets the second line of the file to lastName
              Console.WriteLine(lastName);

              distance = (sr.ReadLine()); //sets the third line of the file to eType
              Console.WriteLine(distance);
                      
              RunnersList.Add(new Runners(firstName, lastName, distance));
         }
         Console.WriteLine("");
         }
      }


      //in the S section - save the file
     /*  else if (userChoice == "S" || userChoice == "s")
        {
          int index;
          string firstName;
          string lastName;
          string distance;

        Console.WriteLine("In the S/s area");
        //delete the file if it exists; for Ratings
        if (File.Exists(fileName))
        {
          File.Delete(fileName);
        }
        using(StreamWriter fileStr = File.CreateText(fileName))
        { //rewrite the data
          for (index = 0; index < RunnersList.Count; index++)
          {
            if(RunnersList[index] != null)
            {
              fileStr.WriteLine(EmployeeArray[index].firstName);
              fileStr.WriteLine(EmployeeArray[index].lastName);
              fileStr.WriteLine(EmployeeArray[index].distance);
            }
          }
        Console.WriteLine(fileName + " has been saved");
        } 
      }
 */

      //now in the R section
      if(userChoice == "R" || userChoice == "r")
      {
        Console.WriteLine("in the R/r area");

        Console.WriteLine("What runner would you like to find?");
        string findRunner = Console.ReadLine();
        bool found = false;
        foreach (Runners theRunner in RunnersList)
        {
          if(theRunner.firstName == findRunner)
          {
            Console.WriteLine(theRunner);
            found = true;
          }
        }
          Console.WriteLine("");
      }
      //create an employee if there is space
      else if(userChoice == "C" || userChoice == "c")
      { 
          int index = 0;

        //gets the employee type to base the questions below on
        Console.WriteLine("What is the runners first name?");
        string newUserFName = Console.ReadLine();
        Console.WriteLine("What is the runners last name?");
        string newUserLName = Console.ReadLine();
        Console.WriteLine("What is the main distance they run?");
        string newDistance = Console.ReadLine();
        
          bool found = false; 
        //index to add it new employee to the array
        for (index = 0; index < RunnersList.Count; index++)
        {
            if((RunnersList[index] == null) && found == false) 
          {
            RunnersList.Add(new Runners(newUserFName, newUserLName, newDistance));
          }
        } //close first for loop
          Console.WriteLine(""); 
      }

      else if(userChoice == "T" || userChoice == "t")
      {
        Console.WriteLine("How many miles did you run today?");
        int milesRan = Convert.ToInt32(Console.ReadLine());
      }

          //in the TL sections
       else if(userChoice == "TL" || userChoice == "tl")
      {
        Console.Write("Enter a date (e.g. 10/22/1987): ");
        DateTime inputtedDate = DateTime.Parse(Console.ReadLine());
        //subtracts your race day - today to get days left
        double daysUntilRace = inputtedDate.Subtract(DateTime.Today).TotalDays;
        double weeksUntilRace = daysUntilRace/7;
        Console.WriteLine("You have " + daysUntilRace + " days until your race");
        Console.WriteLine("You have: " + weeksUntilRace + " weeks until the race!");
        Console.WriteLine("");
      }//close else if  */

      }while (!(userChoice == "Q" || userChoice == "q"));
  }//close main class 
  } //close the class
} //close the namespace








/* using System;

namespace MyApplication
{
class Program
{
/*     static string GetNewRunner()
  {
    Console.WriteLine("Enter the Users First Name");
    string firstName = Console.ReadLine();
    Console.WriteLine("Enter the users Last Name");
    string lastName = Console.ReadLine(); */

/*     }
  static int GetValidMiles()
  {
    Console.WriteLine("How many miles do you run a week?");
    double startMileage = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("By what percent do you want to run more miles each week? Enter as a decimal");
    double upMileage = Convert.ToDouble(Console.ReadLine());
    double validStartMiles = startMileage*upMileage;

    return Convert.ToInt32(validStartMiles);
  } 
     static void Main(string[] args)
      { 
        
        
        
/*

        int index =0;
        double mileage = startingMileage;
        for(index = 0; index > weeksUntilRace; index++)
        {
          mileage = startingMileage  * weeksUntilRace;
        }
          Console.WriteLine("Your new mileage is: " + mileage);
      
      
        Console.WriteLine("Your race is on " + inputtedDate);
      }
}
} */