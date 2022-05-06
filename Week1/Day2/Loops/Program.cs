//if else statement
/*using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Tell me what time it is?");
      string time = Console.ReadLine();
      double timevalue = Convert.ToDouble(time);
      if (timevalue < 18) 
      {
        Console.WriteLine("Good day.");
      } 
      else 
      {
        Console.WriteLine("Good evening.");
      }
    }
  }
}*/

//Switch Statement Test
/*using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What Month is it?");
      string Month = Console.ReadLine();
      switch (Month) 
      {
        case "January":
          Console.WriteLine("January is the 1st month");
          break;
        case "February":
          Console.WriteLine("February is the 2nd month");
          break;
        case "March":
          Console.WriteLine("March is the 3rd month");
          break;
        case "April":
          Console.WriteLine("April is the 4th month");
          break;
        case "May":
          Console.WriteLine("May is the 5th month");
          break;
        case "June":
          Console.WriteLine("June is the 6th month");
          break;
        case "July":
          Console.WriteLine("July is the 7th month");
          break;
        case "August":
          Console.WriteLine("August is the 8th month");
          break;
        case "September":
          Console.WriteLine("September is the 9th month");
          break;
        case "October":
          Console.WriteLine("October is the 10th month");
          break;
        case "November":
          Console.WriteLine("November is the 11th month");
          break;
        case "December":
          Console.WriteLine("December is the 12th month");
          break;
        default:
          Console.WriteLine("That is not a month");
          break;
      }    
    }
  }
} */

//This code is a "for" loop
/*using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i <= 10; i = i + 4)
      {
        Console.WriteLine(i);
      }    
    }
  }
}*/

//This code is a "While" loop
/*using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 5;
      while (i < 9) 
      {
        Console.WriteLine(i);
        i++;
      }
    }
  }
}*/

//This was a test of the conversion ability
/*using System;

namespace MyApplication
{
  class Program
  {
     static void Main(string[] args)
    {
    Console.WriteLine("Please enter the amount of items");
    string pints = Console.ReadLine();
    int pintsvalue = Int32.Parse(pints);
    int cupsvalue = pintsvalue * 4;
    Console.WriteLine("There are " + cupsvalue + " cups in " + pints + "pints");
  }
}
}*/

//while loop not using Numbers
using System;

namespace MyApplication
{
  class Program
  {
     static void Main(string[] args)
    {
      Console.WriteLine("What is my favorite color?");
      string color = Console.ReadLine();
      while (color != "green")
      {
        Console.WriteLine("What is my favorite color?");
        color = Console.ReadLine();
    }
  }
}
} 

