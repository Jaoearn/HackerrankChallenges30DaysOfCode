﻿using System;
using System.IO;

namespace Day29
{
    class Result
    {

        /*
         * Complete the 'bitwiseAnd' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER N
         *  2. INTEGER K
         */

        public static int bitwiseAnd(int N, int K)
        {
            int max = 0;
            int compare = 0;
            for (int i = 1; i < N; i++)
                for (int j = i + 1; j <= N; j++)
                {
                    compare = i & j;
                    max = max < compare && compare < K ? compare : max;
                }
            return max;
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int count = Convert.ToInt32(firstMultipleInput[0]);

                int lim = Convert.ToInt32(firstMultipleInput[1]);

                int res = Result.bitwiseAnd(count, lim);

                textWriter.WriteLine(res);
            }

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
