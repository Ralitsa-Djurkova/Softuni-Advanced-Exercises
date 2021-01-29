using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> addNumber = num => num += 1;
            Func<int, int> multiplayNum = num => num *= 2;
            Func<int, int> subtractNUm = num => num -= 1;
            Action<int[]> print = num => Console.WriteLine(string.Join(" ", num));
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            while (command != "end")
            {
                if(command == "add")
                {
                    input = input.Select(addNumber).ToArray();
                }
                else if(command == "multiply")
                {
                    input = input.Select(multiplayNum).ToArray();
                }
                else if(command == "subtract")
                {
                    input = input.Select(subtractNUm).ToArray();
                }
                else if(command == "print")
                {
                    print(input);
                }
                command = Console.ReadLine();
            }
        }
    }
}
