using System;
using System.Collections.Generic;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> phoneNumber = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] seperatedInput = Console.ReadLine().Split(' ');
                phoneNumber.Add(seperatedInput[0], seperatedInput[1]);
            }
            string input;
            while ((input = Console.ReadLine()) != null)
            {
                if (phoneNumber.ContainsKey(input))
                {
                    Console.WriteLine($"{input}={phoneNumber[input]}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
