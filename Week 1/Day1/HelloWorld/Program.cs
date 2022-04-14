//move the terminal at the bottom to CMD each day
//open a new terminal (if needed) select terminal at the top of the page
using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Please enter the value in feet");
      string feet = Console.ReadLine();
      int feetValue = Int32.Parse(feet);

      while(feetValue < 0)
      {
        Console.WriteLine("That value is invalid. Please enter a valid integer");
        feet = Console.ReadLine();
        feetValue = Int32.Parse(feet);
        
      }
      int inchValue = (feetValue * 12);
      Console.WriteLine("Your total in inches is: " + inchValue);

    }
  }
}
