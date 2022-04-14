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
      //if the option is L or l then load the text file (ValidNames.txt) into the array
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
      //elseif the option is an S or s then store the array into the text file
        
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
            for (int index = 0; index <NameArray.Length; index++)
            {
              fileStr.WriteLine(NameArray[index]);
            }
          }
          Console.WriteLine(fileName + " has been saved");
          }
      //elseif the option is a C or c then add a name to the array (if there is room we will have a limit)
        else if(userChoice == "C" || userChoice == "c")
        {  
          Console.WriteLine("What name do you want to add?");
          string newName = Console.ReadLine();
          bool found = false;
          Console.WriteLine("");
          int index = 0;

          for (index = 0; index < 10; index++)
          //{
            if((NameArray[index] == "Open") && found == false)
            {
              NameArray[index] = newName;
              found = true;

              Console.WriteLine(NameArray[index]); 
            }  
          //}
        }
        
      //elseif the option is an R or r then read a name from the array (if it is there)
        else if(userChoice == "R" || userChoice == "r")
        {
          Console.WriteLine("in the R/r area");
           for (int index = 0; index < 10; index++)
          {
            Console.WriteLine(NameArray[index]);
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
            Console.WriteLine("What value would you like to change " + nameToUpdate);
            string updateName = Console.ReadLine();
            NameArray[index] = updateName;
            }
          }
        }
      //elseif the option is a D or d then delete the name in the array (if it is there)
        else if(userChoice == "D" || userChoice == "d")
        {
          Console.WriteLine("in the D/d area");
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