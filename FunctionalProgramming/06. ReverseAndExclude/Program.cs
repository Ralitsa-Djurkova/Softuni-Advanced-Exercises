﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<int>numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int divisible = int.Parse(Console.ReadLine());

            numbers.Reverse();
            Func<int, bool> predicate = x => x % divisible != 0;
            numbers = numbers.Where(predicate).ToList();
            Console.WriteLine(string.Join(" ", numbers));
           
        }
       

       
    }
}
