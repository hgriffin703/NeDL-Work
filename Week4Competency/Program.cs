﻿using System;
using System.Collections.Generic;

namespace Week4Competency
{
  class Program
   {
    static void Main(string[] args)
    {
        
/*         Saving newAccount = new Saving ("12345", "Savings", 123456.00, .01);
            Console.WriteLine(newAccount);
        Checking newChecking = new Checking("98765", "Checking", 234953.00, 100); //test for salary
            Console.WriteLine(newChecking);
        CD newCD = new CD("34573", "CD", 2345840.00, .10, 100); //test for hourly
            Console.WriteLine(newCD); */

        List<Accounts> AccountList = new List<Accounts>();

        // Add a couple of employees to the list to test
            AccountList.Add(new Saving("12345", "Savings", 100000, .1)); 
            AccountList.Add(new Checking("98765", "Checking", 567094, 100)); 
            AccountList.Add(new CD("10000", "CD", 45000, .25, 150)); 
            AccountList.Add(new Saving("12121", "Savings", 42493, .2));
            AccountList.Add(new Saving("88888", "Savings", 3400, .5)); 
            AccountList.Add(new Checking("34567", "Checking", 1000000, 150)); 
            AccountList.Add(new CD("99999", "CD", 96789, .2, 150)); 
            AccountList.Add(new Saving("10001", "Checking", 23560, 25));


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
 
            //in the L section
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
                    double updateAccountBalance = AccountList[index].accountBalance + enterDeposit; //updates the balance
                    Console.WriteLine("You deposited: " + enterDeposit + " dollars. Your new account balance is: " + updateAccountBalance);
                    Console.WriteLine("");
                  }  
            }
         }




        //now in the W section
        else if(userChoice == "W" || userChoice == "w")
        {
          Console.WriteLine("in the W/w area");
          int index;

          Console.WriteLine("What account number would you like to withdraw from?");
          string withdrawAccount = Console.ReadLine();
          Console.WriteLine("How much would you like to withdraw?");
          double withdrawAmount = Convert.ToDouble(Console.ReadLine());

          for(index = 0; index < AccountList.Count; index++)
          {
            if (AccountList[index].accountType == "Savings")
            {
                if(withdrawAmount > AccountList[index].accountBalance)
                 Console.WriteLine("You do not have enough money to withdraw that much");
                 withdrawAmount = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                double newAmount = AccountList[index].accountBalance - withdrawAmount;
                Console.WriteLine("You withdrew: " + withdrawAmount + " dollars. Your new balance is: " + newAmount);
            }
           /*  if (AccountList[index].accountType == "Checking")
            {
                if(withdrawAmount > AccountList[index].accountBalance)
                 Console.WriteLine("You do not have enough money to withdraw that much");
                 withdrawAmount = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                double newAmount = AccountList[index].accountBalance - withdrawAmount;
                Console.WriteLine("You withdrew: " + withdrawAmount + " dollars. Your new balance is: " + newAmount);
            } */
          }

            Console.WriteLine("");
        }
 

        } while (!(userChoice == "Q" || userChoice == "q"));
      }
    }
}