using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Console.WriteLine(minFunc(numbers));
        }

        static Func<int[], int> minFunc = nums =>
        {
            int minNum = int.MaxValue;

            foreach (var num in nums)
            {
                if(num < minNum)
                {
                    minNum = num;
                }
            }

            return minNum;
        };
    }
}
