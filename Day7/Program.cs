/*using System;

namespace Day7Arrays
 {
   class MyArray
    {
      static void Main(string[] args) 
      { 
          int[] WeatherArray = new int[5];

          for (int days = 0; days < 5; days++)
          {
              Console.WriteLine("What was the weather?");
              WeatherArray[days] = Convert.ToInt16(Console.ReadLine());
          } 
            
            Console.WriteLine("On Monday, the weather was" + WeatherArray[1]);

      }
    }
 }   */

/* using System;
using System.IO;  // include the System.IO namespace

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string writeText = "Hello World! Hayley is here";  // Create a text string
      File.WriteAllText("Day7Files.txt", writeText);  // Create a file and write the contents of writeText to it

      string readText = File.ReadAllText("Day7Files.txt"); // Read the contents of the file
      Console.WriteLine(readText); // Output the content
    }
  }
}*/




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
      string[] NameArray = new string[10];
      string fileName = @"ValidNames.txt";
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
        Console.WriteLine("U: Update a name in the array.");
        Console.WriteLine("D: Delete a name in your array.");
        Console.WriteLine("Q: Quit the program.");
        
        //get a valid user option (valid means it is on menu
        userChoice = Console.ReadLine();

        validUserChoice = (userChoice == "L" || userChoice == "l" 
                          ||userChoice == "S" || userChoice == "s" 
                          || userChoice == "C" || userChoice == "c" 
                          || userChoice == "R" || userChoice == "r"
                          || userChoice == "U" || userChoice == "u" 
                          || userChoice == "D" || userChoice == "d"
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

        int index = 0; //index for the array
        using (StreamReader sr = File.OpenText("ValidNames.txt"))
         {
           string s = "";
				Console.WriteLine(" Here is the content of the file ValidNames.txt : ");
          while ((s = sr.ReadLine()) != null)
            {
              Console.WriteLine(s);
              NameArray[index] = s;
              index = index +1;
            }
            Console.WriteLine("");
         }
        }
      //save/store the array into the text file
        else if(userChoice == "S" || userChoice == "s")
        {
          Console.WriteLine("In the S/s area");
          //delete the file if it exists
          if (File.Exists(fileName))
          {
            File.Delete(fileName);
          }
          using(StreamWriter fileStr = File.CreateText(fileName))
          { //rewrite the data
            for (int index = 0; index < NameArray.Length; index++)
            {
              fileStr.WriteLine(NameArray[index]);
            }
          }
          Console.WriteLine(fileName + " has been saved");
          }
      //add a name to the array (if there is room)
        else if(userChoice == "C" || userChoice == "c")
        { 
           int index = 0;
          Console.WriteLine("What name do you want to add?");
          string newName = Console.ReadLine();
          bool found = false;
          Console.WriteLine(""); //entering a blank line to give some space
          //index to add it to the array
          for (index = 0; index < 10; index++)
          {
            if((NameArray[index] == "") && found == false)
            {
              NameArray[index] = newName;
              found = true;

              Console.WriteLine(NameArray[index]); 
            }  
          } //end the for loop
            if (found == false) //didn't need anything else because this is bool
          {
            Console.WriteLine("There is no space to add");
          }
        }
          
    //if the option is an R or r then read a name from the array (if it is there)
        else if(userChoice == "R" || userChoice == "r")
        {
          Console.WriteLine("in the R/r area");
          Console.WriteLine("Which array spot would you like to find?");
          int findName = Convert.ToInt16(Console.ReadLine());

           for (int index = 0; index < 10; index++)
          {
            Console.WriteLine(NameArray[index]); //fix this
          }
        }
      //elseif the option is a U or u then update a name in the array (if it is there)
        else if(userChoice == "U" || userChoice == "u")
        {
          int index = 0;
          //picks the name to update
         Console.WriteLine("Which name would you like to update?");  
         string nameToUpdate = Console.ReadLine();

         for(index = 0; index < 10; index++)
          {
            if((NameArray[index] == nameToUpdate))
            { //updates the name
            Console.WriteLine("What value would you like to change " + nameToUpdate + " to?");
            string updateName = Console.ReadLine();
            NameArray[index] = updateName;
            }
          }
        }
      //elseif the option is a D or d then delete the name in the array (if it is there)
        else if(userChoice == "D" || userChoice == "d")
        {
         int i = 0;
         Console.WriteLine("What name would you like to remove?");
         string deleteName = Console.ReadLine();

         Console.WriteLine("Elements before deletion:");
         for (i = 0; i < 10; i++) 
         {
            Console.WriteLine(NameArray[i]);
         }
         //gets the indx (position) of the name that should be delete
          string SearchString = deleteName;
          int index = Array.IndexOf(NameArray, SearchString);
          Console.WriteLine(index);

         // Shifts elements depending on the removed value
         for (i = index; i < 9; i++) 
         {
            NameArray[i] = NameArray[i + 1];
         }
         Console.WriteLine("Elements after deletion: ");
         for (i = 0; i < 9; i++) 
         {
            Console.WriteLine( NameArray[i]);
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