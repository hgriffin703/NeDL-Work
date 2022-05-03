using System;
using System.Collections.Generic;
namespace Week5Competency
{
    class Program
    {
        static void Main(string[] args)
        {
          List<Memberships> MembersList = new List<Memberships>();

        // Add a couple of memberships to the list to test
            MembersList.Add(new Regular("10000", "hg@gmail.com", "Regular", 50.00, 150.00)); 
            MembersList.Add(new Executive("10001", "exec@gmail.com", "Executive", 75.00, 500.00)); 
            MembersList.Add(new NonProfit("10002", "nonprofit@hotmail.com", "Non Profit", 25.00, 700.00, "Military")); 
            MembersList.Add(new NonProfit("10003", "NonMilitary@events.com", "Non Profit", 250.00, 2500.00, "Volunteer"));
            MembersList.Add(new Corporate("10004", "Corporate@yahoo.com", "Corporate", 100.00, 2000.00));

            
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

        //in the C section - create a new membership

      if (userChoice == "C" || userChoice == "c")
         {
             bool found = false;
             double newPurchaseAmount = 0;
             string enterMembershipID;
             string newMemType;
             string newMemEmail;
             double newMemAnnualCost;
             Console.WriteLine("What is the account number you would like to add?");
             enterMembershipID =  Console.ReadLine();

               for(int index = 0; index < MembersList.Count; index++)
               {
                if(MembersList[index].membershipID == enterMembershipID)
               {
                found = true;
                break;
               }
                else
                {
                  found = false;
                }
               }  
              if(found == true)
              {
                Console.WriteLine("That membership ID already exists.");
                break;
              }

                Console.WriteLine("what type of membership is it?");
                newMemType = Console.ReadLine();
                Console.WriteLine("Please enter a contact email address");
                newMemEmail = Console.ReadLine();
                Console.WriteLine("Please enter an annual cost of membership");
                newMemAnnualCost = Convert.ToDouble(Console.ReadLine()); 

                switch(newMemType)
                {
                  case "Regular":
                  {
                    MembersList.Add(new Regular(enterMembershipID, newMemEmail, newMemType, newMemAnnualCost, newPurchaseAmount));
                    break;
                  }
                  case "Executive":
                  {
                    MembersList.Add(new Executive(enterMembershipID, newMemEmail, newMemType, newMemAnnualCost, newPurchaseAmount));
                    break;
                  }
                  case "Non Profit":
                  {
                    Console.WriteLine("What type of Non Profit is it?");
                    string newNPType = Console.ReadLine();
                    MembersList.Add(new NonProfit(enterMembershipID, newMemEmail, newMemType, newMemAnnualCost, newPurchaseAmount, newNPType));
                    break;
                  }
                  case "Corporate":
                  {
                    MembersList.Add(new Corporate(enterMembershipID, newMemEmail, newMemType, newMemAnnualCost, newPurchaseAmount));
                    break;
                  }
                }
         } //close the else if loop

         //won't check for account doesn't exist
         else if (userChoice == "U" || userChoice == "u")
         {
            int index;
            bool found = false;

            Console.WriteLine("What account would you like to update the email for?");
            string updatemembership = Console.ReadLine();

          for(index = 0; index < MembersList.Count; index++) 
            {
              if(MembersList[index].membershipID == updatemembership)
              {
                Console.WriteLine("Please enter the new email address?");
                string updateValue = Console.ReadLine();
                MembersList[index].SetEmail(updateValue);
                found = true;
              }
            }
            if (found)
              {
              Console.WriteLine("This has been found and updated");
              }
            else
              Console.WriteLine("This has not been found. Nothing was updated");
              Console.WriteLine("");
         }

         else if(userChoice == "D" || userChoice == "d")
         {
           int index;
           bool found = false;

           Console.WriteLine("which Membership would you like to delete?");
           string deleteMember = Console.ReadLine();
           for(index = 0; index < MembersList.Count; index++)
           {
             if((MembersList[index].membershipID == deleteMember)&& found == false)
             {
               MembersList.RemoveAt(index);
               found = true;
             }
           }
           if(found)
           {
            Console.WriteLine("The members has been deleted. Thank you!");
            Console.WriteLine("");
           }
          else
            Console.WriteLine("The membership was not found. Please enter a valid membership");
            Console.WriteLine("");
         }

          // in the P section for Purchases
         else if (userChoice == "P" || userChoice == "p")
         {
           bool found = false;
          Console.WriteLine("What is the membership ID for the purchase?");
          string purchaseID = Console.ReadLine();
          Console.WriteLine("How much money did you spend (just the number)?");
          double purchaseValue = Convert.ToDouble(Console.ReadLine());
          while(purchaseValue <= 0)
            {
              Console.WriteLine("Your purchase must be more than 0 dollars");
              purchaseValue = Convert.ToDouble(Console.ReadLine());
            }

          for(int index = 0; index < MembersList.Count; index++)
           {
            if((MembersList[index].membershipID == purchaseID)&& found == false)
              {
                MembersList[index].SetNewBalance(purchaseValue); //updates the balance
                Console.WriteLine("You spent: " + purchaseValue + " dollars. Your new balance is: " + MembersList[index].totalPurchaseAmount);
              } //if loop
              else
              {
                Console.WriteLine("That account does not exist. No purchase was added.");
                Console.WriteLine("");
                break;
              }
           } //for loop
         }

         //the T: RETURNS SECTION
         else if (userChoice == "T" || userChoice == "t")
         {
            Console.WriteLine("What is the membership ID for the account?");
            string returnAccount = Console.ReadLine();
            Console.WriteLine("How much in dollars are you returning?");
            double returnAmount = Convert.ToDouble(Console.ReadLine());

            while(returnAmount <= 0)
            {
              Console.WriteLine("Your return cannot be less than or equal to 0");
              returnAmount = Convert.ToDouble(Console.ReadLine());
            }

            for(int index = 0; index < MembersList.Count; index++)
            {
              if(returnAccount == MembersList[index].membershipID)
              {
                MembersList[index].SetReturnBalance(returnAmount); //updates the balance
                Console.WriteLine("You returned: " + returnAmount + " dollars. Your new balance is: " + MembersList[index].totalPurchaseAmount);
              }
              else
              {
                Console.WriteLine("The return was not processed! That account does not exist.");
                Console.WriteLine("");
                break;
              }
            }
         }


         //in the A section
          else if(userChoice == "A" || userChoice =="a")
          {
            Console.WriteLine("What membership ID would you like to get your Cash Back from?");
            string cashbackID = Console.ReadLine();

            for(int index = 0; index < MembersList.Count; index++)
            if(MembersList[index].membershipID == cashbackID)
            {
              MembersList[index].applyCashBack();
            }
          }

         //R/L section
         else if(userChoice == "L" || userChoice == "l" || userChoice == "R" || userChoice == "r")
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
         } while (!(userChoice == "Q" || userChoice == "q")); //closes first do
        }//close the main loop
    }//closes the class
}//closes the namespace
