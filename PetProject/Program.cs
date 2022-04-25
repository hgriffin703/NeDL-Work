using System;

namespace MyApplication
{
  class Program
  {
    static int GetValidMiles()
    {
      Console.WriteLine("How many miles do you run a week?");
      double startMileage = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("By what percent do you want to run more miles each week? Enter as a decimal");
      double upMileage = Convert.ToDouble(Console.ReadLine());
      double validStartMiles = startMileage*upMileage;

      return Convert.ToInt32(validStartMiles);
      }
      static void Main(string[] args)
    { //user enters the date of the race
      int startingMileage = GetValidMiles();
      Console.Write("Enter a date (e.g. 10/22/1987): ");
      DateTime inputtedDate = DateTime.Parse(Console.ReadLine());
      //subtracts your race day - today to get days left
      double daysUntilRace = inputtedDate.Subtract(DateTime.Today).TotalDays;
      double weeksUntilRace = daysUntilRace/7;

      int index =0;
      double mileage = startingMileage;
      for(index = 0; index > weeksUntilRace; index++)
      {
        mileage = startingMileage  * weeksUntilRace;
      }
        Console.WriteLine("Your new mileage is: " + mileage);
     
     
      Console.WriteLine("Your race is on " + inputtedDate);
      Console.WriteLine("You have " + daysUntilRace + " days until your race");
      Console.WriteLine("You have: " + weeksUntilRace + " weeks until the race!");
    }
  }
}