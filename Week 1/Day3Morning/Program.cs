//create code that will get the average min and max temperature in F
/*using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
        //initialize variables
        int i = 0;
        int min = 125;
        int max = -80;
        int sum = 0;
        int Average = 0;
        //ask question about how much weather to track
        Console.WriteLine("How long would you like to track the weather for?");
        int days = Convert.ToInt16(Console.ReadLine());

        //for loop
      for (i = 0; i < days; i++)
      {
          Console.WriteLine("What was the temperature?");
          int temp = Convert.ToInt16(Console.ReadLine());

          while(temp < -80 || temp > 125)
          {
            Console.WriteLine("That temp is invalid. Please enter the temp again.");
            temp = Convert.ToInt16(Console.ReadLine());
          } //close the while loop
          //find the MIN
          if(temp < min)
            min = temp;
         //find the MAX
          if(temp > max)
            max = temp;
         //find the average
           sum+= temp;
           Average = (sum/days); 
        
      } //close the for loop
       Console.WriteLine("The min temp is: " + min);
       Console.WriteLine("The max temp is: " + max);
       Console.WriteLine("The average of the temps was: " + Average);
    }
  }
} */

//testing how to create Methods
/*using System;

namespace MyApplication
{
  class Program
  {
    static void Testing() //this is the actual method to call
    { //this is what the method will do
      Console.WriteLine("Does this work as I expect?");
      string Hayley = Console.ReadLine();
      Console.WriteLine("This is what you entered: " + Hayley);
    }

    static void Main(string[] args) //<- not sure yet what this does
    { // calling the method to use
      Testing();
    }
  }
}*/

//testing out the Arrays
/*using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    { //create array and write the value given
      string[] fruits = {"orange", "apple", "banana", "grape", "pineapple", "blueberry"};
      Console.WriteLine(fruits[4]);
    }
  }
}*/

//do-while loop
/*using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 1;
      do 
      {
        Console.WriteLine(i);
        i++;
      }
      while (i < 5);
    }
  }
}*/

//if else test
/*using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the names of your student");
        string stuName = Console.ReadLine();
        if (stuName != "Jenny")
        {
            Console.WriteLine("That is not the student I am thinking of. Try again!");
        }
        else
        { 
        Console.WriteLine("That is the student I am thinking of!");
        }
   }
  }
}*/

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        int i = 0;
        Console.WriteLine("how many authors do you have?");
        int numOfNames = Convert.ToInt16(Console.ReadLine());

        for(i = 0; i < numOfNames; i++)
        {
            Console.WriteLine("What is the name of the first author?");
            string Name = Console.ReadLine();
        }
    }
  }
}

