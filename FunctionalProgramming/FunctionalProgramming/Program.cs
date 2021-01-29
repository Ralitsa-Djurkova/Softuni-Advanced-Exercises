using System;
using System.Linq;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ");

            Action<string[]>printName = a => Console.WriteLine(string.Join(Environment.NewLine, a));
            printName(names);
            
        }
       
        
    }
   
}
