using System;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            static void PrintResult(string word)
            {
                string Even = ""; 
                string Odd = "";

                for (int i = 0; i < word.Length; i++)
                {

                    if (i % 2 == 0)
                    {
                        Even = Even + word[i];
                    }
                    else
                    {
                        Odd = Odd + word[i];
                    }
                }
                Console.WriteLine("{0} {1}", Even, Odd);
            }

            for (int i = 0; i < n; i++)
            {
                PrintResult(Console.ReadLine().Trim());
            }
        }
    }
}
