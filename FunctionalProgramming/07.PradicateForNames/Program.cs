using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PradicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, bool> rightNames = x => x.Length <= lenght;

            names = names.Where(rightNames).ToList();
            Console.WriteLine(string.Join(Environment.NewLine,names));
        }
    }
}
