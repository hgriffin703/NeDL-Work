using System;

namespace MyApplication
{
  class Program
  {
    static double MilesPerWeek()
    {
    Console.WriteLine("How many miles do you run a week?");
    double Mileage = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("By what percent do you want to run more miles each week? Enter as a decimal");
    double upMileage = Convert.ToDouble(Console.ReadLine());
    double newMileage = (Mileage*upMileage)+ Mileage;
    
    return newMileage;
  }
      static void Main(string[] args)
    { //user enters the date of the race
    double newMileage = MilesPerWeek();
      Console.Write("Enter a date (e.g. 10/22/1987): ");
      DateTime inputtedDate = DateTime.Parse(Console.ReadLine());
      //subtracts your race day - today to get days left
      double daysUntilRace = inputtedDate.Subtract(DateTime.Today).TotalDays;
      Console.WriteLine("Your race is on " + inputtedDate);
      Console.WriteLine("You have " + daysUntilRace + " days until your race");
      Console.WriteLine("Next week you should run: " + newMileage);
    }
  }
}