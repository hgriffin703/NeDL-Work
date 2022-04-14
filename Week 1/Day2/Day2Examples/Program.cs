using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        //portion to determine how many quizzes there were
        Console.WriteLine("How many quizzes were taken?");
        string quizNum = Console.ReadLine();
        int quizNumber = Int16.Parse(quizNum);

        //call all of the variables prior to starting
        double i=0;
        double sum = 0;
        double max = 0;
        double min = 100;

        //for loop to get all of the quiz results
        for (i = 0; i < quizNumber; i++)
        {
            Console.WriteLine("What was the score on the quiz");
            double quizValue = Convert.ToDouble(Console.ReadLine());
        //while loop to ensure the values are between 0 and 100
        while(quizValue < 0.0 || quizValue > 100.0)
        {
            Console.WriteLine("That is not a valid score. Please enter the test score");
            quizValue = Convert.ToDouble(Console.ReadLine());   
        }//closes the while loop

        //if statement to find the lowest of the value
        if(quizValue < min)
        {
            min = quizValue;
        }

        //if statement to find the highest value
        if(quizValue > max)
        {
           max = quizValue;
        } 
        //sum to get the value of all of the quizzes combiined
        sum += quizValue;
        } //closes the for loop

         Console.WriteLine("The sum of all of the quizzes is: " + sum);
        // line to find the average value
          double Average = sum/quizNumber;
          Console.WriteLine("The average of the quizzes was " + Average);
         Console.WriteLine("This is your highest test score " + max);
         Console.WriteLine("This is your lowest test score " + min);
    }
  }
  }

