using System;

namespace MyApplication
{
  class Program
  {
      static void Main(string[] args)
    { //user enters the date of the race
      Console.WriteLine("How many miles do you run a week?");
      double startMileage = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("By what percent do you want to run more miles each week? Enter as a decimal");
      double upMileage = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter a date (e.g. 10/22/1987): ");
      DateTime inputtedDate = DateTime.Parse(Console.ReadLine());
      //subtracts your race day - today to get days left
      double daysUntilRace = inputtedDate.Subtract(DateTime.Today).TotalDays;
      double weeksUntilRace = daysUntilRace/7;

      double nextWeeksMileage;
      for (int index = 0; index < weeksUntilRace; index++)
      {
        double moreMilesToRun = startMileage * upMileage;
        double eachWeeksMileage = moreMilesToRun + startMileage;
      for (int index2 = 0; index2 <weeksUntilRace; index2++)
      {
        nextWeeksMileage = eachWeeksMileage * moreMilesToRun;
      }
      }
      Console.WriteLine("Week " + index + " you should run " + nextWeeksMileage);
     
     
     
      Console.WriteLine("Your race is on " + inputtedDate);
      Console.WriteLine("You have " + daysUntilRace + " days until your race");
      Console.WriteLine("You have: " + weeksUntilRace + " weeks until the race!");
    }
  }
}