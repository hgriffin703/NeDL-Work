using System;
using System.Collections.Generic;

namespace Week4Competency
{
  class Program
   {
    static void Main(string[] args)
    {
        List<Accounts> AccountList = new List<Accounts>();

        // Add a couple of accounts to the list to test
            AccountList.Add(new Saving("12345", "Savings", 100000, .1)); 
            AccountList.Add(new Checking("98765", "Checking", 56700, 100)); 
            AccountList.Add(new CD("10000", "CD", 45000, .25, 150)); 
            AccountList.Add(new Saving("12121", "Savings", 42000, .2));
            AccountList.Add(new Saving("88888", "Savings", 3400, .5)); 
            AccountList.Add(new Checking("34567", "Checking", 1000000, 150)); 
            AccountList.Add(new CD("99999", "CD", 96500, .2, 150)); 
            AccountList.Add(new Saving("10001", "Checking", 23500, 25));


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
        Console.WriteLine("L: List all of the account information");
        Console.WriteLine("D: Deposit money into an account");
        Console.WriteLine("W: Withdraw from an account");
        Console.WriteLine("Q: Quit the program.");
        
        //get a valid user option (valid means it is on menu
        userChoice = Console.ReadLine();

        validUserChoice = (userChoice == "L" || userChoice == "l" 
                          ||userChoice == "D" || userChoice == "d" 
                          || userChoice == "W" || userChoice == "w" 
                          || userChoice == "Q" || userChoice == "q");

        if(!validUserChoice)
        {
          Console.WriteLine("Please enter a valid option");
        }

          } while (!validUserChoice); 
 
            //in the L section - to read the accounts out
        if(userChoice == "L" || userChoice == "l")
        {
          Console.WriteLine("in the L/l area");

         for (int index = 0; index < AccountList.Count; index++)
          {
            if(AccountList[index] != null)
            {
               Console.WriteLine(AccountList[index]);
            } 
          } //close for loop
            Console.WriteLine("");
        }

        //in the D section - deposit amount

      else if (userChoice == "D" || userChoice == "d")
         {
             int index;
             bool found = false;

             Console.WriteLine("What is the account number for the deposit?");
             string enterAccountNum =  Console.ReadLine();

            // checks if the account exists
             AccountList.Find(item => item.accountID != enterAccountNum);
             Console.WriteLine("That account does not exist. Please enter another");
             enterAccountNum = Console.ReadLine();

            //asks for the deposit amount
             Console.WriteLine("How much would you like to deposit?");
             double enterDeposit = Convert.ToDouble(Console.ReadLine());

             //checks that the deposit is greater than 0
            while(enterDeposit <= 0)
            {
                Console.WriteLine("Your deposit must be greater than 0");
                enterDeposit = Convert.ToDouble(Console.ReadLine());
            }

            //checks for the account
            for(index = 0; index < AccountList.Count; index++)
            {
              if ((AccountList[index].accountID == enterAccountNum) && found == false)
                {
                  AccountList[index].makeDeposit(enterDeposit); //updates the balance
                  Console.WriteLine("You deposited: " + enterDeposit + " dollars. Your new account balance is: " + AccountList[index].accountBalance);
                  Console.WriteLine("");
                }  
            }
         }

        //now in the W section - to get the withdrawal
        else if(userChoice == "W" || userChoice == "w")
        {
          int index;

          Console.WriteLine("What account number would you like to withdraw from?");
          string withdrawAccount = Console.ReadLine();
          Console.WriteLine("How much would you like to withdraw?");
          double withdrawAmount = Convert.ToDouble(Console.ReadLine());

          while(withdrawAmount <= 0.0)
            {
              Console.WriteLine("Your withdrawal must be more than $0. Please enter a diferent amount");
              withdrawAmount = Convert.ToDouble(Console.ReadLine());
            }

         for(index = 0; index < AccountList.Count; index++)
          { //savings account portion
            if ((AccountList[index].accountID == withdrawAccount) && AccountList[index].accountType == "Savings")
            {
              if(withdrawAmount > AccountList[index].accountBalance)
              {
                Console.WriteLine("You do not have enough money to withdraw that much. Thank you!");
              }
             
            else if((AccountList[index].accountID == withdrawAccount) && AccountList[index].accountType == "Savings")
            {
              AccountList[index].getWithdrawal(withdrawAmount); //updates the balance
              Console.WriteLine("You withdrew: " + withdrawAmount + " dollars. Your new balance is: " + AccountList[index].accountBalance);
            }
          }

            //this portion is for the checking account
           if ((AccountList[index].accountID == withdrawAccount) && AccountList[index].accountType == "Checking")
              {
                if(withdrawAmount >= (AccountList[index].accountBalance * .5))
                {
                 Console.WriteLine("You can't withdraw more than 50% out of your Checking Account. Thank you!");
                }
              
                else if ((AccountList[index].accountID == withdrawAccount) && AccountList[index].accountType == "Checking")
                {
                  AccountList[index].getWithdrawal(withdrawAmount); //updates the balance
                  Console.WriteLine("You withdrew: " + withdrawAmount + " dollars. Your new balance is: " + AccountList[index].accountBalance);
                }
              }



               //this portion is for the CD account
            if ((AccountList[index].accountID == withdrawAccount) && AccountList[index].accountType == "CD")
              { // wrong amount
                if(withdrawAmount >= (AccountList[index].accountBalance - AccountList[index].GetEarlyFee()))
                {
                 Console.WriteLine("You are charged a penalty of: " +AccountList[index].GetEarlyFee() + " for withdrawing early so you can't withdraw this amount. Please try again");
                }
              
                else if ((AccountList[index].accountID == withdrawAccount) && AccountList[index].accountType == "CD")
                { //correct amount
                  AccountList[index].getWithdrawal(withdrawAmount); //updates the balance
                  Console.WriteLine("You withdrew: " + withdrawAmount + " dollars, plus the early fee of: " + AccountList[index].GetEarlyFee() + ". New balance is: " + AccountList[index].accountBalance);
                }
              }
          } //closes the for loop
        } //closes the else if

            Console.WriteLine("");
 
          //quits the program
        } while (!(userChoice == "Q" || userChoice == "q"));
      }
    }
}
