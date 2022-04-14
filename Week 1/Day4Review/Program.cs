/*Problem description:  Create a program that will obtain a base from the 
user and an exponent from the user and will print out the value of the base
 taken to the exponent power.  Use a method, Power, to calculate the value.
Be sure that both the base and exponent are integers greater than or equal 
to 1. Repeat the process until the user wants to quit.*/
/*using System;

namespace HelloWorld
{
  class Program
  {
      static int Power(int value, int baseValue)
      {
          int i = 0;
          Console.WriteLine("What is your base Value?");
          int bValue = Convert.ToInt16(Console.ReadLine());
        while (bValue < 0)
        {
            Console.WriteLine("That is not a valid value");
            bValue = Convert.ToInt16(Console.ReadLine());
        }
            Console.WriteLine("What is your exponent value?");
            int eValue = Convert.ToInt16(Console.ReadLine());
        while (eValue < 0)
        {
            Console.WriteLine("That is not a valid value");
            eValue = Convert.ToInt16(Console.ReadLine());
        }
        //calculate the power; by using 1 and then a multiple for base
        //this will have it increment each time for the number of eValue
         int powerValue = 1;
        for (i = 1; i <= eValue; i++)
           powerValue = powerValue*bValue;

            return powerValue; 
           
      }
    static void Main(string[] args)
    {
        int x = 0;
        int y = 0;
        string keepGoing = "yes";
        do
        {
          int total = Power(x,y);
          Console.WriteLine("Here is your value: " + total + ". Would you like to go again?"); 
          keepGoing = Console.ReadLine();
        } while (keepGoing == "yes");
    }
  }
} */

/*Problem description:  Create a program that will obtain a base from the
 user, a beginning exponent from the user, and an ending exponent from the
  user and will print out the value of the base taken to the exponent power
   for all of the exponents from the beginning to the ending exponent.  
   Use a method, Power, to calculate the value.  Be sure that both the 
   base and exponents are integers greater than or equal to 1, and that
    the ending exponent is greater than the beginning exponent. Repeat the
     process until the user wants to quit.  */
using System;

namespace HelloWorld
{
  class Program
  {
      static int Power()
      {
          Console.WriteLine("What is your base Value?");
          int baseValue = Convert.ToInt16(Console.ReadLine());
        while (baseValue < 0)
        {
            Console.WriteLine("That is not a valid value. Enter a new value");
            baseValue = Convert.ToInt16(Console.ReadLine());
        }
            Console.WriteLine("What is your low exponent value?");
            int lowExponent = Convert.ToInt16(Console.ReadLine());

        while (lowExponent < 0)
        {
            Console.WriteLine("That is not a valid value. Enter a new value");
            lowExponent = Convert.ToInt16(Console.ReadLine());
        }
         Console.WriteLine("What is your high exponent value?");
            int highExponent = Convert.ToInt16(Console.ReadLine());

        while (highExponent < 0)
        {
            Console.WriteLine("That is not a valid value. Enter a new value");
            highExponent = Convert.ToInt16(Console.ReadLine());
        }
        //calculate the power; by using 1 and then a multiple for base
        //this will have it increment each time for the number of eValue
        int powerValue = 1;
        int j;
        //this first for loop prints out the info
        for (int i=lowExponent; i <= highExponent; i++) 
        { // the inner loop does the math for the outer loop
            for (j=1; j <= i; j++) {
                powerValue = baseValue * powerValue;
        }
        Console.WriteLine(baseValue + " to the power of " + (j-1) + " is " + powerValue);
        powerValue = 1;

        }
        return powerValue;
      }
        static void Main(string[] args)
        {
            string keepGoing = "yes";
        do
        {
          int total = Power();
          Console.WriteLine("Do you want to continue? yes or no"); 
          keepGoing = Console.ReadLine();
        }
         while (keepGoing == "yes");
        } 
      }
  }
      
      