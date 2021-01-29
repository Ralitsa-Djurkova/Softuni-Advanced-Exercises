using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            names = names.Select(n => $"Sir {n}").ToList();

            Action<string[]> printNames = x => Console.WriteLine(string.Join(Environment.NewLine,x));
            printNames(names.ToArray());

            
            
        }
        
       
    }
}
