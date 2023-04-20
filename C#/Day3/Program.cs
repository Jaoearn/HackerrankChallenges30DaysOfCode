using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());
            if (N % 2 == 0)
            {
                if (N <= 5 && N >= 2)
                {
                    Console.Write("Not Weird");
                }
                else if (N <= 20 && N >= 6)
                {
                    Console.Write("Weird");
                }
                else
                {
                    Console.Write("Not Weird");
                }
            }
            else
            {
                Console.Write("Weird");
            }
        }
    }
}
