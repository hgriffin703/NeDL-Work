using System;

namespace HelloWorld
{
  class Program
  {
      static int GetValidInt(int x, int y)
      {
         //Method to get the quiz Scores
         int quizNumber;
         int quizScore = 0;
         int sum = 0;
         int Average= 0;
        for (quizNumber = 1; quizNumber <=3; quizNumber++)
         while(quizNumber <= 3)
         { 
          Console.WriteLine("Please enter a quiz score for Quiz Number " + quizNumber);
          quizScore = Convert.ToInt16(Console.ReadLine());
          quizNumber++;
          //checks that the quiz score is between 1 and 100
          while (quizScore < 0 || quizScore > 100)
          {
              Console.WriteLine("That is not a valid quiz score. Please enter it again");
              quizScore = Convert.ToInt16(Console.ReadLine());
          }
            sum+= quizScore;
            Average = sum/3;
          }
          return Average;
      }
       static int GetValidHW(int x, int y)
      {
         //Method to get the homework Scores
         int hwNumber;
         int hwScore = 0;
         int sumHw = 0;
         int AverageHw = 0;
        for (hwNumber = 1; hwNumber <=5; hwNumber++)
         while(hwNumber <= 5)
         { 
          Console.WriteLine("Please enter a homework score for Homework Number " + hwNumber);
          hwScore = Convert.ToInt16(Console.ReadLine());
          hwNumber++;
          while (hwScore < 0 || hwScore > 100)
          {
              Console.WriteLine("That is not a valid homework score. Please enter it again");
              hwScore = Convert.ToInt16(Console.ReadLine());
          }
          sumHw+= hwScore;
          AverageHw = sumHw/5;
          }
          return AverageHw;
      }
       static int GetValidExam(int x, int y)
      {
         //Method to get the Exam Scores
         int examNumber;
         int examScore = 0;
         int sumExam = 0;
         int AverageExam = 0;
        for (examNumber = 1; examNumber <=2; examNumber++)
         while(examNumber <= 2)
         { 
          Console.WriteLine("Please enter a exam score for Exam Number " + examNumber);
          examScore = Convert.ToInt16(Console.ReadLine());
          examNumber++;
          while (examScore < 0 || examScore > 100)
          {
              Console.WriteLine("That is not a valid exam score. Please enter it again");
              examScore = Convert.ToInt16(Console.ReadLine());
          }
          sumExam+= examScore;
          AverageExam = sumExam/2;
          }
          return AverageExam;
      }
      static void Main(string[] args)
    {  //portion to determine how many students there were
        Console.WriteLine("How many students do you have?");
        int students = Convert.ToInt16(Console.ReadLine());
       //loops through the students
        while (students <= 0)
        {
            Console.WriteLine("You must have more than one student. Please enter a new class size.");
            students = Convert.ToInt16(Console.ReadLine());
        } 
        //gets the student number for the teacher
        for (int i = 1; i <= students; i++)
        { // get the name of the student
            Console.WriteLine("Please enter the students name");
            string studentName = Console.ReadLine();    
        //loops through the students and the methods for their grades
        int QuizGrades = GetValidInt(0,100);
        int homeworkGrades = GetValidHW(0,100);
        int examGrades = GetValidExam(0,100);
        double FinalAverage = (QuizGrades*.3)+(homeworkGrades*.5)+(examGrades*.2);
        //displays all of the values
        Console.WriteLine("The student you are getting grades for is: " + studentName);
        Console.WriteLine("Average Quiz Grade for " + studentName + ": " + QuizGrades);
        Console.WriteLine("Avera Homework Grade for " + studentName + ": " + homeworkGrades);
        Console.WriteLine("Average Exam Grade for " + studentName + ": " + examGrades);
        Console.WriteLine("The average total Grade for " + studentName + " was " + FinalAverage);
        //determines the letter grade of the student
              if(90 <= FinalAverage && FinalAverage <= 100)
        {
            Console.WriteLine("The Final Grade for " + studentName + " is an A!");
        }
        else if (80 <= FinalAverage && FinalAverage <= 89)
        {
            Console.WriteLine("The Final Grade for " + studentName + " is a B!");
        }
        else if (70 <=FinalAverage && FinalAverage < 79)
        {
            Console.WriteLine("The Final Grade for " + studentName + " is a C");
        }
        else if (60 <= FinalAverage && FinalAverage < 69)
        {
            Console.WriteLine("The Fial Grade for " + studentName + " is a D");
        }
        else{Console.WriteLine("The Final Grade for " + studentName + " is an F");
        }
        }
        } 
    }
  }

