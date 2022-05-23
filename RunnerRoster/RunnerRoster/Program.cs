using System;
using System.Collections.Generic;

namespace RunnerRoster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char selection;

            List<Runners> RunnersList = new List<Runners>();
            RunnersList.Add(new Runners("Derek", "Loseke", "Marathon", "Boston Marathon"));
            RunnersList.Add(new Runners("Hayley", "Griffin", "Half Marathon", "Good Life Halfsy"));
            do
            {
                Console.WriteLine("what would you like to do today?");
                Console.WriteLine("A or a: Add a new runner and race");
                Console.WriteLine("R or r: Reads the runners already entered");
                Console.WriteLine("Quits the program");

                selection = Convert.ToChar(Console.ReadLine());

                if (selection == 'A' || selection == 'a')
                {
                    bool found = false;

                    Console.WriteLine("What is the runners first name?");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("What is the runners last name?");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("What is the race name?");
                    string raceName = Console.ReadLine();
                    Console.WriteLine("what is the race distance?");
                    string raceDistance = Console.ReadLine();

                    for (int index = 0; index < RunnersList.Count; index++)
                    {
                        if (found == false)
                        {
                            RunnersList.Add(new Runners(firstName, lastName, raceDistance, raceName));
                            found = true;
                        }
                    }
                    if (found == false)
                    {
                        Console.WriteLine("There is no room to add this runner!");
                        Console.WriteLine("");
                    }
                }
                else if (selection == 'R' || selection == 'r')
                {
                    for (int index = 0; index < RunnersList.Count; index++)
                        Console.WriteLine(RunnersList[index]);
                }
            } while (!(selection == 'Q' || selection == 'q'));
         }//closes main
    } //closes class
}//closes namespace
