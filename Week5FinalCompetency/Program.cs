using System;
using System.Collections.Generic;
namespace Week5Competency
{
    class Program
    {
        static void Main(string[] args)
        {
            
         bool validUserChoice = false;
            string userChoice;

            do 
          {
            do
          {
        //initialize variables
        validUserChoice = false;
        //provide the user a menu of options
        Console.WriteLine("What would you like to do today?");
        Console.WriteLine("C: Create a new membership");
        Console.WriteLine("R: List all of the memberships");
        Console.WriteLine("U: Update a membership");
        Console.WriteLine("D: Delete a membership");
        Console.WriteLine("L: List all memberships");
        Console.WriteLine("P: Add a purchase");
        Console.WriteLine("T: Return an Item");
        Console.WriteLine("A: Apply the cash back reward");
        Console.WriteLine("Q: Quit the program.");
        
        //get a valid user option (valid means it is on menu
        userChoice = Console.ReadLine();

        validUserChoice = (userChoice == "C" || userChoice == "c" 
                          ||userChoice == "R" || userChoice == "r" 
                          || userChoice == "U" || userChoice == "u" 
                          || userChoice == "D" || userChoice == "d"
                          ||userChoice == "L" || userChoice == "l" 
                          ||userChoice == "P" || userChoice == "p" 
                          || userChoice == "T" || userChoice == "t"
                          || userChoice == "A" || userChoice == "a" 
                          || userChoice == "Q" || userChoice == "q");

        if(!validUserChoice)
        {
          Console.WriteLine("Please enter a valid option");
        }

          } while (!validUserChoice);


            List<Memberships> MembersList = new List<Memberships>();

        // Add a couple of memberships to the list to test
            MembersList.Add(new Regular("10000", "hg@gmail.com", "Regular", 50.00, 150.00, .1)); 
            MembersList.Add(new Executive("10001", "exec@gmail.com", "Executive", 75.00, 500.00, .2)); 
            MembersList.Add(new NonProfit("10002", "nonprofit@hotmail.com", "Non Profit", 25.00, 700.00, .15)); 
            MembersList.Add(new Corporate("10003", "Corporate@yahoo.com", "Corporate", 100.00, 2000.00, .25));

            //in the L section - to read the accounts out
        if(userChoice == "L" || userChoice == "l" || userChoice == "R" || userChoice == "r")
        {
          Console.WriteLine("in the R/r pr L/l area");

         for (int index = 0; index < MembersList.Count; index++)
          {
            if(MembersList[index] != null)
            {
               Console.WriteLine(MembersList[index]);
            } 
          } //close for loop
            Console.WriteLine("");
        }

        //in the C section - create a new membership

      else if (userChoice == "C" || userChoice == "c")
         {
             int index;
             bool found = false;
             double newPurchaseAmount = 0;
             string enterMembershipID;
             string newMemType;
             string newMemEmail;
             double newMemAnnualCost;
             double newMemCashback;

             Console.WriteLine("What is the account number you would like to add?");
             enterMembershipID =  Console.ReadLine();

            // checks if the account exists
          for(index = 0; index < MembersList.Count; index++) 
          {
             if ((MembersList[index].membershipID == enterMembershipID) && found == false)
              {
                Console.WriteLine("This is membership ID already exists. Please enter a different ID");
                enterMembershipID = Console.ReadLine();;
              }
              else if(enterMembershipID != MembersList[index].membershipID)
              {
                Console.WriteLine("what type of membership is it?");
                newMemType = Console.ReadLine();
                Console.WriteLine("Please enter a contact email address");
                newMemEmail = Console.ReadLine();
                Console.WriteLine("Please enter an annual cost of membership");
                newMemAnnualCost = Convert.ToDouble(Console.ReadLine()); 
                Console.WriteLine("What is the annual percent of cash back?");
                newMemCashback = Convert.ToDouble(Console.ReadLine());

              switch(newMemType)
              {
                case "Regular":
                MembersList.Add(new Regular(enterMembershipID, newMemEmail, newMemType, newMemAnnualCost, newPurchaseAmount, newMemCashback));
                break;
                case "Corporate":
                MembersList.Add(new Corporate(enterMembershipID, newMemEmail, newMemType, newMemAnnualCost, newPurchaseAmount, newMemCashback));
                break;
                case "Non Profit":
                MembersList.Add(new NonProfit(enterMembershipID, newMemEmail, newMemType, newMemAnnualCost, newPurchaseAmount, newMemCashback));
                break;
                case "Executive":
                MembersList.Add(new Executive(enterMembershipID, newMemEmail, newMemType, newMemAnnualCost, newPurchaseAmount, newMemCashback));
                break;
              }
              break;
              }
          }//close the for loop
         } //close the else if loop
         else if (userChoice == "U" || userChoice == "u")
         {
            int index;
            bool found = false;

            Console.WriteLine("What account would you like to update?");
            string updatemembership = Console.ReadLine();

          for(index = 0; index < MembersList.Count; index++) 
            {
              if(MembersList[index].membershipID == updatemembership)
              {
              Console.WriteLine("Please enter the new value to update?");
              string updateValue = Console.ReadLine();
              MembersList[index].SetEmail(updateValue);
              found = true;
              }
            }
           foreach (Memberships theMember in MembersList)
           Console.WriteLine(theMember);
         }
         } while (!(userChoice == "Q" || userChoice == "q")); //closes first do
        }//close the main loop
    }//closes the class
}//closes the namespace
