using System;
using System.Collections.Generic;
using System.Linq;

namespace Day11
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }
            List<int> hourglasses = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int first = arr[i][j];
                    int second = arr[i][j + 1];
                    int third = arr[i][j + 2];
                    int middle = arr[i + 1][j + 1];
                    int fourth = arr[i + 2][j];
                    int fifth = arr[i + 2][j + 1];
                    int sixth = arr[i + 2][j + 2];

                    hourglasses.Add(first + second + third + middle + fourth + fifth + sixth);
                }
            }
            Console.WriteLine(hourglasses.Max());
        }
    }
}
