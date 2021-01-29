using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> peopleNames = Console.ReadLine().Split().ToList();
            List<string> filters = new List<string>();
            string command = Console.ReadLine();

            while (command != "Print")
            {
                string[] cmdArg = command.Split(";");
                if(cmdArg[0] == "Add filter")
                {
                    filters.Add(cmdArg[1] + " " + cmdArg[2]);
                }
                else if(cmdArg[0] == "Remove filter")
                {
                    filters.Remove(cmdArg[1] + " " + cmdArg[2]);
                }
                command = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                var commands = filter.Split();

                if(commands[0] == "Starts")
                {
                    peopleNames = peopleNames.Where(p => !p.StartsWith(commands[2])).ToList();
                }
                else if(commands[0] == "End")
                {
                    peopleNames = peopleNames.Where(p => !p.EndsWith(commands[2])).ToList();
                }
                else if(commands[0] == "Length")
                {
                    peopleNames = peopleNames.Where(p => p.Length != int.Parse(commands[1])).ToList();
                }
                else if(commands[0] == "Contains")
                {
                    peopleNames = peopleNames.Where(p => !p.Contains(commands[1])).ToList();
                }
            }
            if (peopleNames.Any())
            {
                Console.WriteLine(string.Join(" ", peopleNames));
            }
        }
    }
}
