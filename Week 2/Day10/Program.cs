using System;
using System.IO;  // include the System.IO namespace

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      //declare variables
      bool validUserChoice = false;
      string userChoice;
      string[] RNameArray = new string[25];
      string[] RRatingArray = new string[25];
      string RfileName = @"Restaurants.txt";
      string fileName = @"Ratings.txt";
      //get a valid input
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
        Console.WriteLine("C: Add a name to the array.");
        Console.WriteLine("R: Read a name from your array.");
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

        //loads the file structure into the Array
        if(userChoice == "L" || userChoice == "l")
        {
          Console.WriteLine("this is the L area");

        int index = 0; //index for the restarray
        int ratingIndex = 0; //index for ratingarray
        //Restaurants file upload
        using (StreamReader sr = File.OpenText("Restaurants.txt"))
         {
           string rating = ""; 
          while ((rating = sr.ReadLine()) != null)
            {
              RNameArray[index] = rating;
              index = index +1;
            }
            Console.WriteLine("");
         }
            //loadfile for Restaurant
 
            using (StreamReader tr = File.OpenText("Ratings.txt"))
         {
           string restaurant = "";
          while ((restaurant = tr.ReadLine()) != null)
            {
              RRatingArray[ratingIndex] = restaurant;
              ratingIndex = ratingIndex +1;
            }
            Console.WriteLine("");
         }
         }

      //save/store the array into the text file
        else if(userChoice == "S" || userChoice == "s")
        {
          Console.WriteLine("In the S/s area");
          //delete the file if it exists; for Ratings
          if (File.Exists(RfileName))
          {
            File.Delete(RfileName);
          }
          using(StreamWriter fileStr = File.CreateText(RfileName))
          { //rewrite the data
            for (int index = 0; index < RNameArray.Length; index++)
            {
              fileStr.WriteLine(RNameArray[index]);
            }
          }
          Console.WriteLine(RfileName + " has been saved");

            //writes files for Restaurants
           if (File.Exists(fileName))
          {
            File.Delete(fileName);
          }
          using(StreamWriter fileStr = File.CreateText(fileName))
          { //rewrite the data
            for (int index = 0; index < RRatingArray.Length; index++)
            {
              fileStr.WriteLine(RRatingArray[index]);
            }
          }
          Console.WriteLine(fileName + " has been saved");
          }
      //add a name to the array (if there is room)
        else if(userChoice == "C" || userChoice == "c")
        { 
           int index = 0;
           int ratingIndex = 0;
          Console.WriteLine("What restaurant do you want to add?");
            string newRestaurant = Console.ReadLine();
          Console.WriteLine("What rating do you want to give it?");
            int newRating = Convert.ToInt16(Console.ReadLine());

            while(newRating > 5 || newRating < 0)
            {
                Console.WriteLine("Your rating must fall between 1 and 5");
                newRating = Convert.ToInt16(Console.ReadLine());
            }
          bool found = false; //found for rest.
          bool ratingfound = false; // found for rating
          Console.WriteLine(""); //entering a blank line to give some space
          
          //index to add it new rest to the array
          for (index = 0; index < RNameArray.Length; index++)
          {
            if((RNameArray[index] == "") && found == false)
            {
              RNameArray[index] = newRestaurant;
              found = true;

              Console.WriteLine(RNameArray[index]); 
            }  
          } //end the for name loop
          
            if (found == false) 
          {
            Console.WriteLine("There is no space to add a new restaurant!");
            Console.WriteLine("");

          } //see if a new rating can be entered
            for (ratingIndex = 0; ratingIndex < RRatingArray.Length; ratingIndex++)
            {
               if((RRatingArray[ratingIndex] == "") && ratingfound == false)
            {
              RRatingArray[ratingIndex] = Convert.ToString(newRating);
              ratingfound = true;

              Console.WriteLine(RRatingArray[ratingIndex]); 
            }  //close if statement for Rating
          } //end the for rating loop
          
            if (ratingfound == false) //didn't need anything else because this is bool
          {
            Console.WriteLine("There is no space to add a new rating");
            Console.WriteLine("");
          } //close if statement for rating not available
        }
          
    //if the option is an R or r then read a name from the array (if it is there)
         else if(userChoice == "R" || userChoice == "r")
        {
          Console.WriteLine("in the R/r area");
          Console.WriteLine("Which restaurant value (0-24), would you like to see the rating for?");
          int numberRest = Convert.ToInt16(Console.ReadLine());
            //loops to find numberRest name
            for (int index = 0; index < RNameArray.Length; index++)
          { // loops to find numberRest value
            for (int ratingIndex = 0; ratingIndex < RRatingArray.Length; ratingIndex++)
            {
            }// close for loop for the rating
          }
         Console.WriteLine("The restaurant at spot "+ numberRest + " is: " +RNameArray[numberRest] + " and it has a rating of: " + RRatingArray[numberRest]);
         Console.WriteLine(""); //blank line for better viewing
         Console.WriteLine("");

         for (int index2 = 0; index2 < RNameArray.Length; index2++)
          {
            if(RNameArray[index2] != "")
            {
               Console.WriteLine(RNameArray[index2]);
               Console.WriteLine(RRatingArray[index2]);
            }
          }
        } 
          //else quit program because Q or q were used
          else
        {
          Console.WriteLine("Have a nice day!");
        }
      } while (!(userChoice == "Q" || userChoice == "q"));
    } //ends main
  }//ends program
} //end namespace
