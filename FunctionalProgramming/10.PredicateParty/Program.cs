using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<string> names = Console.ReadLine().Split().ToList();
            Func<string, int, bool> lenghtFunc = (name, lenght) => name.Length == lenght;
            Func<string, string, bool> startWithFunc = (name, pattern) => name.StartsWith(pattern);
            Func<string, string, bool> endWithFunc = (name, pattern) => name.EndsWith(pattern);
           string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] cmArg = command.Split(" ");
                string condition = cmArg[1];
                string param = cmArg[2];
                if (cmArg[0]  == "Remove")
                {
                    if (condition == "Length")
                    {
                        int lenght = int.Parse(param);
                        names = names.Where(x => !lenghtFunc(x, lenght)).ToList();
                        
                    }
                    else if (condition == "StartsWith")
                    {
                       names = names.Where(name => !startWithFunc(name, param)).ToList();
                       

                    }
                    else if (condition == "EndsWith")
                    {
                        names = names.Where(name => !endWithFunc(name, param)).ToList();
                        

                    }
                }
                else if(cmArg[0] == "Double")
                {
                    if(condition == "Length")
                    {
                        int lenght = int.Parse(param);
                        var tempNames = names.Where(x => lenghtFunc(x, lenght)).ToList();
                        MyAddRange(names, tempNames);
                    }
                    else if(condition == "StartsWith")
                    {
                        var tempNames = names.Where(name => startWithFunc(name, param)).ToList();
                        MyAddRange(names, tempNames);
                    }
                    else if(condition == "EndsWith")
                    {
                        var tempNames = names.Where(name => endWithFunc(name, param)).ToList();
                        MyAddRange(names, tempNames);
                    }
                }
                command = Console.ReadLine();
            }
            if(names.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ",names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void MyAddRange(List<string> names, List<string> tempNames)
        {
            foreach (var currentName in tempNames)
            {
                int index = names.IndexOf(currentName);
                names.Insert(index, currentName);
            }
        }
    }
}
