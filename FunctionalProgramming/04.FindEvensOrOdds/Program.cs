using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEvenPredicat = num => num % 2 == 0;
            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));

            int[] input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            List<int> numbers = new List<int>();

            int start = input[0];
            int end = input[1];

            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }

            string numberType = Console.ReadLine();

            if(numberType == "even")
            {
                numbers.RemoveAll(x => !isEvenPredicat(x));
            }
            else
            {
                numbers.RemoveAll(isEvenPredicat);
            }

            print(numbers);
        }
    }
}
