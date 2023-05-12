using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Day28
{
    class Program
    {
        public static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());
            Regex nameRegex = new Regex(@"[a-z]{1,20}");
            Regex emailRegex = new Regex(@"[a-z\@\.]{1,50}@gmail.com$");
            List<string> names = new List<string>();

            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                string firstName = firstMultipleInput[0];

                string emailID = firstMultipleInput[1];

                if (nameRegex.IsMatch(firstName) && emailRegex.IsMatch(emailID))
                    names.Add(firstName);
            }
            names.Sort();
            foreach (string name in names)
                Console.WriteLine(name);
        }
    }
}
