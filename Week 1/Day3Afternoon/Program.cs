using System;

namespace MyApplication
{
  class Program
  { 
      static int GetValidInt(int x, int y)
      {
          
          Console.WriteLine("Please enter a value: ");
          int value = Convert.ToInt16(Console.ReadLine());
          while (value < x || value > y)
          {
            Console.WriteLine("Please enter a valid value: ");
            value = Convert.ToInt16(Console.ReadLine());
          }
          return value;
      }
         static int MyMin(int x, int y)
     { 
         if(x > y)
           { return x;
        }
         else 
         {
            return y; 
             } 
     }
         static int MyMax(int x, int y)
     { 
         if(x < y)
         {
             return x;
         }
         else {
             return y;
         } 
     }
    static void Main(string[] args)
    {
        int quizValue = GetValidInt(0, 100);
        int quizValue2 = GetValidInt(0,100);
        int MinValue = MyMin(quizValue, quizValue2);
        int MaxValue = MyMax(quizValue, quizValue2);

         Console.WriteLine("This is your highest test score " + MinValue);
         Console.WriteLine("This is your lowest test score " + MaxValue);
    }
  }
  }

