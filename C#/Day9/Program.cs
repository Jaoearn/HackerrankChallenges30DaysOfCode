using System;
using System.IO;

namespace Day9
{
    class Result
    {
        public static int factorial(int n)
        {

            if (n == 0)
            {
                return 1;
            }
            return n * factorial(n - 1);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.factorial(n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
