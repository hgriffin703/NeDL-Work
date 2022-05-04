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
