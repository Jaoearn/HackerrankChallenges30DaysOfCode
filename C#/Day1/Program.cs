using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int value1 = Convert.ToInt32(Console.ReadLine());
            double value2 = Convert.ToDouble(Console.ReadLine());
            string value3 = Console.ReadLine();
            Console.WriteLine(value1 + i);
            Console.WriteLine(String.Format("{0:0.0}", value2 + d));
            Console.WriteLine(s + value3);

        }
    }
}
