using System;
using System.Collections.Generic;

namespace Day17
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Runners newRunner = new Runners ("Molly", "Seidel"); */
            Events RaceInfo = new Events ("Molly", "Seidel", "Marathon", "Tokyo Olympics", "3rd Place");
            Console.WriteLine(RaceInfo);
        }
    }
}
