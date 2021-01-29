using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> getAskii = p => p.Select(c => (int)c).Sum();
            int n = int.Parse(Console.ReadLine());
            List<string> people = Console.ReadLine().Split().ToList();
            string person = GetName(people, n, getAskii);
            Console.WriteLine(person);
            
        }
        static string GetName(List<string> people, int n, Func<string, int> predicate)
        {
            string restult = null;
            foreach (var item in people)
            {
                if(predicate(item) >= n)
                {
                    restult = item;
                }
            }

            return restult;
        }
    }
}
