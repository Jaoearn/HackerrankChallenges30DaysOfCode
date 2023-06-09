﻿using System;

namespace Day2
{
    class Result
    {
        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            var tip = (meal_cost * tip_percent) / 100;
            var tax = (tax_percent * meal_cost) / 100;
            var total = meal_cost + tip + tax;
            Console.WriteLine(Math.Round(total, 0, MidpointRounding.AwayFromZero));
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());


            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());


            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());


            Result.solve(meal_cost, tip_percent, tax_percent);
        }
    }

}
