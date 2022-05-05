/* using System;
namespace MyApplcation
{
    class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("What is the height of the triangle?");
        int h = Convert.ToInt32(Console.ReadLine());
        while (1 > h || h > 1000)
        {
        Console.WriteLine("Your value must be between 1 and 1000");
        h = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("What is the base length of the triangle?");
        int b = Convert.ToInt32(Console.ReadLine());
        while (1 > b || b > 1000)
        {
        Console.WriteLine("Your value must be between 1 and 1000");
        b = Convert.ToInt32(Console.ReadLine());
        }
        double area = (b*h)*.5;
        Console.WriteLine("The area is: " + area);
    }
    }
} */
/* 
using System;
namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            Console.WriteLine("What is the wizards magic number?");
            int N = Convert.ToInt32(Console.ReadLine());
            while(1 > N || N > 100)
            {
                Console.WriteLine("Must be between 1 and 100");
                N = Convert.ToInt32(Console.ReadLine()); 
            }
            for(index = 0; index < N; index++)
            {
                Console.WriteLine("Abracadabra");
            }
        }
    }
} */
/* 
using System;
namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value 1");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick your second value");
            int value2 = Convert.ToInt32(Console.ReadLine());
            if(value1 > value2)
            {
                Console.WriteLine(1);
            }
            else 
            {
                Console.WriteLine(0);
            }
        }
    }
} */

/* using System;
namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("How many contestants?");
           int N = Convert.ToInt16(Console.ReadLine());
           Console.WriteLine("How many huffle-puff problems are there?");
           int P = Convert.ToInt16(Console.ReadLine());

           for(int index = 0; index < N; index++)
           {
               while (index < N)
               {
                   Console.WriteLine("Describe the next contestant");
                   string description = Console.ReadLine();
                   index++;
               }
           }
           Console.WriteLine("You are going to give out " + P + " carrots!");
        }
    }
} */

/* using System;
namespace KattisPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the value of R1?");
            int R1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the value of S1?");
            int S1 = Convert.ToInt32(Console.ReadLine());
            int R2 = (2*S1)-R1;
            Console.WriteLine(R2);
        }
    }
} */

using System;
namespace KattisPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
