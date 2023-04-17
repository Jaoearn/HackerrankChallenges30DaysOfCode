using System;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            if (n >= 2 && 20 >= n)
            {
                for (int i = 1; i < 11; i++)
                {
                    string input = n.ToString();
                    string loop = i.ToString();
                    int result = n * i;
                    Console.WriteLine(input + " x " + loop + " = " + result);
                }
            }
        }
    }
}
