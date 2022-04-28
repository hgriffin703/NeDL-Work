using System;
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
            AccountList.Add(new Checking("13569", "Checking", 567094, 100)); 
            AccountList.Add(new CD("39403", "CD", 45000, .25, 150)); 
            AccountList.Add(new Saving("23059", "Savings", 42493, .2));
            AccountList.Add(new Saving("30865", "Savings", 3400, .5)); 
            AccountList.Add(new Checking("34333", "Checking", 1000000, 150)); 
            AccountList.Add(new CD("99999", "CD", 96789, .2, 150)); 
            AccountList.Add(new Saving("10001", "Checking", 23560, 25));
    }
   }
}
