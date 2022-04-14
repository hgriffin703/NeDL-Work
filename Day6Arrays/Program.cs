/*using System;
using System.Linq;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] cars = {"Volvo", "Chevy", "BMW", "Ford"}; 
        Console.WriteLine(cars[1]);
    }
  }
}*/

/*using System;
using System.Linq;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] myNumbers = {5, 1, 8, 9};
      Console.WriteLine(myNumbers.Max());  // largest value
      Console.WriteLine(myNumbers.Min());  // smallest value
      Console.WriteLine(myNumbers.Average());  // sum of myNumbers
    }
  }
}*/
 
 /*using System;

namespace ArrayApplication {
   class MyArray {
      static void Main(string[] args) {
         /* an array with 5 rows and 2 columns
         int[,] a = new int[5, 2] {{0,0}, {1,2}, {2,4}, {3,6}, {4,8} };
         int i, j;
         
         output each array element's value 
         for (i = 0; i < 5; i++) {
            
            for (j = 0; j < 2; j++) {
               Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i,j]);
            }
         }
         Console.ReadKey();
      }
   }
} */

/*using System;

namespace ArrayApplication {
   class MyArray {
      static void Main(string[] args) 
      {//this top portion gets the number of scores to be collected
          int[] grades = new int[10];
          for (int numberofScores = 0; numberofScores < 10; numberofScores++)
          {
                Console.WriteLine("Please enter your quiz score");
                grades[numberofScores] = Convert.ToInt32(Console.ReadLine());
          }// closes number of scores for loop
          //finds the max
                int max = grades[0];
            for (int i = 1; i < 10; i++) 
            {
                if (grades[i] > max) 
                {
                 max = grades[i];
                }//close max if
            }//closes max for
        Console.WriteLine("The highest quiz score is: " + max);
            //finds the min
               int min = grades[0];
            for (int x = 1; x < 10; x++) 
            {
                if (grades[x] < min) 
                {
                 min = grades[x];
                } //end if min value      
            } // end for the min for
            Console.WriteLine("The lowest quiz score is: " + min);
            //variables for the for each sum loop
           int sum = 0; 
           int average = 0;
        { //open for each loop  
        foreach (int allgrades in grades)
        {
            sum += allgrades;
            average = sum/10;
        }
        Console.WriteLine("The sum of all of the scores is: " + sum);
        Console.WriteLine("The average of the scores is: " + average);
        }//close the for each loop
     } //closes the main clause   
    }
}*/

//Two dimensional array!
using System;

namespace ArrayApplication
 {
   class MyArray
    {
      static void Main(string[] args) 
      {         
      int[,] grades = new int[4, 4];
         for(int numberofStudents = 1; numberofStudents < 4; numberofStudents++)
         {//get the value for the columns that are the students numbers
         Console.WriteLine("Please enter the number of your next student in the class");
         int studentNumber = Convert.ToInt32(Console.ReadLine());
         //get the values for the scores
            for(int scores = 0; scores < 4; scores++) {
               Console.WriteLine("Please enter the students grade");
         //input those values into our array
         grades[scores,studentNumber] = Convert.ToInt32(Console.ReadLine());
           }
         } //output the 2nd students, third score
         Console.WriteLine("The value at 1,2 is: " + grades[1,2]);   
      }
    }
 }
     
 

