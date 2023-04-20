using System;
using System.Linq;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            string Result = Convert.ToString(n, 2).Split('0').Max();
            Console.WriteLine(Result.Length);
        }
    }
}