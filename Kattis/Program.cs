/*using System;

namespace HelloWorld
{
  class Program
  {  
    static void Main(string[] args)
    {
        Console.WriteLine("Pick an X Value");
        int xValue = Convert.ToInt32(Console.ReadLine());
        while (-1000 >= xValue || xValue >=1000 || xValue == 0)
        {
            Console.WriteLine("That is not a valid value. Please select a new value");
            xValue = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Pick a Y value");
        int yValue = Convert.ToInt32(Console.ReadLine());
        while (-1000 >= yValue || yValue >= 1000 || yValue == 0)
        {
            Console.WriteLine("This is not a valid value. Please input a new value");
            yValue = Convert.ToInt32(Console.ReadLine());
        }
        if(-1000 <=xValue && xValue < 0 && -1000 <= yValue && yValue < 0)
        {
            Console.WriteLine("3");
        }
        else if (1 <= xValue && xValue <= 1000 && 1 <= yValue && yValue <=1000)
        {
            Console.WriteLine("1");
        }
        else if (-1000 <=xValue && xValue < 0 && 1 <= yValue && yValue <=1000)
        {
            Console.WriteLine("2");
        }
        else 
        {
            Console.WriteLine("4");
        }
    }
  }
}*/

using System;

namespace HelloWorld
{
  class Program
  {  
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a value for eyes.");
        int N = Convert.ToInt16(Console.ReadLine());
        while (N < 0 || N >= 500)
        {
            Console.WriteLine("That is not a valid value. Please enter a value between 1 and 500");
            N = Convert.ToInt16(Console.ReadLine());
        }
        Console.WriteLine("Please enter a value for nose.");
        int T = Convert.ToInt16(Console.ReadLine());
        while (T < 0 || T >= 500)
        {
            Console.WriteLine("That is not a valid value. Please enter a value between 1 and 500");
            T = Convert.ToInt16(Console.ReadLine());
        }
        Console.WriteLine("Please enter a value for mouth.");
        int M = Convert.ToInt16(Console.ReadLine());
        while (M < 0 || M >= 500)
        {
            Console.WriteLine("That is not a valid value. Please enter a value between 1 and 500");
            M = Convert.ToInt16(Console.ReadLine());
        }
        int possOutcome = N*T*M;
        Console.WriteLine(possOutcome);
    }
  }
}